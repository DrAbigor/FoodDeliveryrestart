using FoodDeliveryrestart.Components;
using FoodDeliveryrestart.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FoodDeliveryrestart.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<FoodDeliveryrestartContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodDeliveryrestartContext") ?? throw new InvalidOperationException("Connection string 'FoodDeliveryrestartContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<AuthState>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

