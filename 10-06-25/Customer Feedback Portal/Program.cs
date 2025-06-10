using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Customer_Feedback_Portal.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Customer_Feedback_PortalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Customer_Feedback_PortalContext") ?? throw new InvalidOperationException("Connection string 'Customer_Feedback_PortalContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
