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

// UserManager and SignInManager are registered by Identity; do not register them manually.

// Email sender
builder.Services.AddTransient<IEmailSender<FoodDeliveryrestartUser>, NoOpEmailSender>();

// Application services
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<GroupOrderState>();

var app = builder.Build();

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

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();