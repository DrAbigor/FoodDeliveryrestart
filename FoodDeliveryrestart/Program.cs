using FoodDeliveryrestart.Components;
using FoodDeliveryrestart.Services;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryrestart.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Database
builder.Services.AddDbContextFactory<FoodDeliveryrestartContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FoodDeliveryrestartContext")
        ?? throw new InvalidOperationException("Connection string 'FoodDeliveryrestartContext' not found.")
    )
);

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ✅ Custom Authentication
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>(provider =>
    (CustomAuthenticationStateProvider)provider.GetRequiredService<AuthenticationStateProvider>());

// Provide access to HttpContext for auth helpers
builder.Services.AddHttpContextAccessor();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorization();

// ✅ Identity - Minimal setup
builder.Services.AddDbContext<FoodDeliveryrestartContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodDeliveryrestartContext")));

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

// ✅ Configure Identity Cookie Paths - ADD THIS
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";
    options.LogoutPath = "/logout";
    options.AccessDeniedPath = "/access-denied";
});

// UserManager and SignInManager are registered by Identity; do not register them manually.

// Email sender
builder.Services.AddTransient<IEmailSender<FoodDeliveryrestartUser>, NoOpEmailSender>();

// Application services
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<GroupOrderState>();

var app = builder.Build();

// Logout endpoint (GET) - signs out and redirects to home
app.MapGet("/auth/logout", async (SignInManager<FoodDeliveryrestartUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/");
});

// Configure pipeline
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

// ✅ Add Authentication & Authorization Middleware - ADD THIS
app.UseAuthentication();
app.UseAuthorization();

// Server endpoint to accept login POST from the client script and set Identity cookie
app.MapPost("/auth/login", async (HttpContext http, UserManager<FoodDeliveryrestartUser> userManager, SignInManager<FoodDeliveryrestartUser> signInManager) =>
{
    var form = await http.Request.ReadFormAsync();
    var email = form["Email"].ToString();
    var password = form["Password"].ToString();

    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
    {
        return Results.Redirect("/login?error=missing");
    }

    var user = await userManager.FindByEmailAsync(email.Trim());
    if (user == null)
    {
        return Results.Redirect("/login?error=invalid");
    }

    var result = await signInManager.CheckPasswordSignInAsync(user, password, false);
    if (!result.Succeeded)
    {
        return Results.Redirect("/login?error=invalid");
    }

    await signInManager.SignInAsync(user, isPersistent: false);

    var roles = await userManager.GetRolesAsync(user);
    if (roles.Contains("Administrator"))
        return Results.Redirect("/admin");

    return Results.Redirect("/profile");
});

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();