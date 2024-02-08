using Infrastructure_WebReklam.Context;
using Infrastructure_WebReklam.Context.IdentityContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ApplicationCore_WebReklam.Entities.UserEntities.Concrete;
using Infrastructure_WebReklam.AutoMapper;
using AutoMapper;
using Infrastructure_WebReklam.Services.Interfaces;
using Infrastructure_WebReklam.Services.Concrate;
using Microsoft.Extensions.DependencyInjection;

namespace Web_WebReklam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            builder.Services.AddSingleton(mapper);

            builder.Services.AddScoped<ICityRepository, CityRepository>();
            builder.Services.AddScoped<IVillageRepository, VillageRepository>();
            builder.Services.AddScoped<IDesignerRepository, DesignerRepository>();
            builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
            builder.Services.AddScoped<IRequestFormRepository, RequestFormRepository>();


            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(options => { options.UseNpgsql(connectionString); });


            var connectionStringIdentity = builder.Configuration.GetConnectionString("IdentityDbConnection");
            builder.Services.AddDbContext<AppIdentityDbContext>(options => { options.UseNpgsql(connectionStringIdentity); });

            builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
            {
                x.SignIn.RequireConfirmedPhoneNumber = false;
                x.SignIn.RequireConfirmedAccount = false;
                x.SignIn.RequireConfirmedEmail = false;
                x.User.RequireUniqueEmail = true;
                x.Password.RequiredLength = 1;
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireLowercase = false;
            })
              .AddEntityFrameworkStores<AppIdentityDbContext>()
              .AddDefaultTokenProviders()
               .AddDefaultUI(); ;


         
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


            app.MapRazorPages();
            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
