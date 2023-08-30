using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using UserManagement.Data;

namespace UserManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<UserContext>(options =>
              options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(10, 6, 14))));

            builder.Services.AddAuthentication();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}