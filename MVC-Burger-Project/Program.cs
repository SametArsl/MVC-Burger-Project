using Microsoft.AspNetCore.Identity;
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
                })
                .AddRoles<AppRole>()
                .AddEntityFrameworkStores<Context>();

            builder.Services.AddAuthentication(options =>//EKLENDÝ
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            });

            builder.Services.ConfigureApplicationCookie(
                option =>
                {
                    option.LoginPath = "/Identity/Account/Login";
                    option.AccessDeniedPath = new PathString("/Burger/AccessDenied");
                    option.Cookie.Name = "UserCookie";
                    option.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                    option.SlidingExpiration = true;
                });

            builder.Services.AddAuthorization(options =>//EKLENDÝÝ
            {
                options.AddPolicy("RequireAdminRole", policy =>
                {
                    policy.RequireRole("Manager");
                });

            });

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())//EKLENDÝ
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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