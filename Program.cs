using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using findmyworkspace.Data;
namespace findmyworkspace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<findmyworkspaceContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("findmyworkspaceContext") ?? throw new InvalidOperationException("Connection string 'findmyworkspaceContext' not found.")));

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
        }
    }
}
