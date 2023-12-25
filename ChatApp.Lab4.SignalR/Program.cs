using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ChatApp.Lab4.SignalR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:3000")
                .UseStartup<Startup>();
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        var builder = WebApplication.CreateBuilder(args);

    // // Add services to the container. builder.Services.RegisterRepositories(); builder.Services.RegisterServices();

    // var connectionString = builder.Configuration.GetConnectionString("SageBookContext") ?? throw new InvalidOperationException("Connection string
    // 'SageBookContext' not found.");

    // //builder.Services.AddDbContext<SageBookContext>(options => // options.UseSqlServer(connectionString, x =>
    // x.MigrationsAssembly("SageBook.Migrations"))); //builder.Services.AddDefaultIdentity<IdentityUser>(o => //{ // o.SignIn.RequireConfirmedAccount
    // = false; // o.Password.RequiredLength = 5; // o.Password.RequireDigit = false; // o.Password.RequireNonAlphanumeric = false; //
    // o.Password.RequireLowercase = false; // o.Password.RequireUppercase = false; //}) // .AddRoles<IdentityRole>() //
    // .AddEntityFrameworkStores<SageBookContext>() // .AddDefaultTokenProviders(); //builder.Services.AddControllersWithViews(); //builder.Services.AddSession();

    // var app = builder.Build();

    // // Configure the HTTP request pipeline. if (!app.Environment.IsDevelopment()) { app.UseExceptionHandler("/Order/Error"); // The default HSTS
    // value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts. app.UseHsts(); }

    // app.UseHttpsRedirection(); app.UseStaticFiles();

    // app.UseRouting();

    // app.UseAuthentication(); app.UseAuthorization(); app.UseSession();

    // app.MapControllerRoute(
    // name: "default",
    // pattern: "{controller=Order}/{action=Index}/{id?}");

    //        app.Run();
    //    }
    //}
}