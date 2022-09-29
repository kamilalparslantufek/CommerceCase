using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Commerce;
using Commerce.Data.Engine.Core.Database;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("cs") ?? throw new InvalidOperationException("Connection string 'CommercePanelContextConnection' not found.");

builder.Services.AddDbContext<DatabaseContext>(options =>
    options
    .UseLazyLoadingProxies()
    .UseSqlServer(connectionString, p => p.MigrationsAssembly("Commerce.Panel")));    


builder.Services.AddDefaultIdentity<Commerce.Data.Engine.Entity.Designer.User>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<DatabaseContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.Services.CreateScope().ServiceProvider.GetService<DatabaseContext>().Migrate().Wait();
    
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
