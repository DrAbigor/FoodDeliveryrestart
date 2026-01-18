using FoodDeliveryrestart.Components;
using FoodDeliveryrestart.Services;
using FoodDeliveryrestart.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// =======================
// Database
// =======================
builder.Services.AddDbContextFactory<FoodDeliveryrestartContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FoodDeliveryrestartContext")
        ?? throw new InvalidOperationException("Connection string 'FoodDeliveryrestartContext' not found.")
    )
);

// Identity needs scoped DbContext (not factory)
builder.Services.AddDbContext<FoodDeliveryrestartContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FoodDeliveryrestartContext")
        ?? throw new InvalidOperationException("Connection string 'FoodDeliveryrestartContext' not found.")
    )
);

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// =======================
// Razor Components
// =======================
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// =======================
// Custom Authentication State Provider
// =======================
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>(provider =>
    (CustomAuthenticationStateProvider)provider.GetRequiredService<AuthenticationStateProvider>());

builder.Services.AddHttpContextAccessor();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorization();

// =======================
// Identity
// =======================
builder.Services.AddIdentity<FoodDeliveryrestartUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<FoodDeliveryrestartContext>()
.AddRoles<IdentityRole>()
.AddSignInManager()
.AddDefaultTokenProviders();

// ✅ Cookie Paths (custom pages)
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";
    options.LogoutPath = "/auth/logout";
    options.AccessDeniedPath = "/access-denied";
});

// Email sender
builder.Services.AddTransient<IEmailSender<FoodDeliveryrestartUser>, NoOpEmailSender>();

// App services
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<GroupOrderState>();

var app = builder.Build();

// =======================
// Custom Auth Endpoints
// =======================

// ✅ Logout endpoint (GET) -> go to login page
app.MapGet("/auth/logout", async (SignInManager<FoodDeliveryrestartUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/login");
});

// Optional safety
app.MapGet("/logout", () => Results.Redirect("/auth/logout"));

// ✅ Login endpoint (POST) -> sets identity cookie
app.MapPost("/auth/login", async (
    HttpContext http,
    UserManager<FoodDeliveryrestartUser> userManager,
    SignInManager<FoodDeliveryrestartUser> signInManager) =>
{
    var form = await http.Request.ReadFormAsync();
    var email = form["Email"].ToString();
    var password = form["Password"].ToString();

    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        return Results.Redirect("/login?error=missing");

    var user = await userManager.FindByEmailAsync(email.Trim());
    if (user == null)
        return Results.Redirect("/login?error=invalid");

    var result = await signInManager.CheckPasswordSignInAsync(user, password, false);
    if (!result.Succeeded)
        return Results.Redirect("/login?error=invalid");

    await signInManager.SignInAsync(user, isPersistent: false);

    var roles = await userManager.GetRolesAsync(user);
    if (roles.Contains("Administrator"))
        return Results.Redirect("/admin");

    return Results.Redirect("/profile");
});

// =======================
// Pipeline
// =======================
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
