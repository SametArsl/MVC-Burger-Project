using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;

namespace MVC_Burger_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));

            builder.Services.AddIdentity<AppUser, AppRole>(
                option =>
                {
                    option.Password.RequiredLength = 6;
                }
                ).AddEntityFrameworkStores<Context>();

            builder.Services.ConfigureApplicationCookie(
                option =>
                { // Düzenle
                    // option.LoginPath = "/Register/Login";
                    // option.AccessDeniedPath = "AccessDenied";
                    option.Cookie.Name = "UserCookie";
                    option.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                    option.SlidingExpiration = true;
                }
                );

            var app = builder.Build();

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
            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //Path.Combine(builder.Environment.ContentRootPath, "burgerdoc")),
            //    RequestPath = "/Content"
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Burger}/{action=Index}/{id?}");

            app.MapRazorPages();
            app.UseCors( x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.Run();
        }
    }
}