using GestionComercial.Data.Data;
using GestionComercial.Data.Repositorios;
using GestionComercial.Data.Repositorios.Interfaces;
using GestionComercial.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GestionComercial.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configurar Log4Net
            builder.Logging.ClearProviders();
            builder.Logging.AddLog4Net("log4net.config");

            // Add services to the container.
            var applicationConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(applicationConnectionString));


            var gestionComercialConnectionString = builder.Configuration.GetConnectionString("GestionComercialConnection") ?? throw new InvalidOperationException("Connection string 'GestionComercialConnection' not found.");
            
            builder.Services.AddDbContext<GestionComercialDbContext>(options =>
                options.UseSqlServer(gestionComercialConnectionString));

            // Registro de los repositorios en el contenedor de servicios
            builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();


            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
