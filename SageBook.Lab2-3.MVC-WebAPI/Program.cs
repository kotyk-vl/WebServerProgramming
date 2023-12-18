using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SageBook.Data.Models;
using SageBook.Repository;
using SageBook.Repository.Interfaces;
using SageBook.Service.Interfaces;
using SageBook.Service.Services;

namespace SageBook.Lab2_3.MVC_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.RegisterRepositories();
            builder.Services.RegisterServices();

            var connectionString =
                builder.Configuration.GetConnectionString("SageBookContext")
                ?? throw new InvalidOperationException("Connection string 'SageBookContext' not found.");

            builder.Services.AddDbContext<SageBookContext>(options =>
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("SageBook.Migrations")));
            builder.Services.AddDefaultIdentity<IdentityUser>(o =>
            {
                o.SignIn.RequireConfirmedAccount = false;
                o.Password.RequiredLength = 5;
                o.Password.RequireDigit = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<SageBookContext>()
                .AddDefaultTokenProviders();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Order/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Order}/{action=Index}/{id?}");

            app.Run();
        }
    }

    public static class BuilderExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ISageRepository, SageRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ISageService, SageService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}