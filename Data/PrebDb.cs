using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrebDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                SeedData( scope.ServiceProvider.GetRequiredService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("---> Seeding Data...");

                context.Platforms.AddRange(
                    new Platform { Id = 1, Name = "DotNet", Publisher = "Microsoft", Cost = "Free" },
                    new Platform { Id = 2, Name = "SQL Server", Publisher = "Microsoft", Cost = "Free" },
                    new Platform { Id = 3, Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                );
                context.SaveChanges();
            }

            else
            {
                Console.WriteLine("---> We already have data");
            }
        }

    }
}