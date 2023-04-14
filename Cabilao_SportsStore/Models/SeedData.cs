using Microsoft.EntityFrameworkCore;
namespace Cabilao_SportsStore.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();

			}

			if (!context.Products.Any())
			{
				context.Products.AddRange
				(

					new Product
					{
						Name = "Kayak",
						Description = "A boat for one person",
						Category = "Watersports",
						Price = 500.89m
					},

					new Product
					{
						Name = "Lifejacket",
						Description = "Protective and fashionable",
						Category = "Watersports",
						Price = 300.70m
					},

					new Product
					{
						Name = "Soccerball",
						Description = "FIFA - approved sized and weight",
						Category = "Soccer",
						Price = 400.50m
					},

					new Product
					{
						Name = "Corner Flags ",
						Description = "Give your playing field a profesional touch",
						Category = "Soccer",
						Price = 270.70m
					},

					new Product
					{
						Name = "Chessboard",
						Description = "A board for chess sports",
						Category = "Chess",
						Price = 675.90m
					}

				);
				context.SaveChanges();

			}
		}
	}
}
