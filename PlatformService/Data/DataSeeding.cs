using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public static class DataSeeding
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext dbContext)
        {
            if (!dbContext.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                dbContext.Platforms.AddRange(
                     new Platform() { Name="Dot Net", Publisher="Microsoft", Cost="Free"},
                     new Platform() { Name="SQL Server", Publisher="Database", Cost="Free"},
                     new Platform() { Name="Linux", Publisher="Apple", Cost="Free"}
                    );

                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}
