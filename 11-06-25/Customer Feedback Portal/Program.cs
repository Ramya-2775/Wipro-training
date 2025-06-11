using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Customer_Feedback_Portal.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Database context
builder.Services.AddDbContext<Customer_Feedback_PortalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Customer_Feedback_PortalContext")
        ?? throw new InvalidOperationException("Connection string 'Customer_Feedback_PortalContext' not found.")));

// Register required services
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();       
builder.Services.AddSession();                      
builder.Services.AddHttpContextAccessor();          

var app = builder.Build();

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();  

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();