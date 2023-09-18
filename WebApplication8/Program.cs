using Microsoft.EntityFrameworkCore;
using OnliceShop.Core.Interfaces;
using OnliceShop.Core.Services;
using OnlineShop.Core.Interfaces;
using OnlineShop.Infrastructure.Repositories;

namespace WebApplication8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
           
            builder.Services.AddDbContext<OnlineShopDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyShopDb")));
            builder.Services.AddScoped<UnitOfWork>();

         
            builder.Services.AddScoped<IProductRepository,ProductRepository>();
             builder.Services.AddScoped<IProductService,ProductService>();   
          
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}