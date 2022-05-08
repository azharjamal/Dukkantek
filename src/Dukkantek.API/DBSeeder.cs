using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dukkantek.Domain.Models;
using Dukkantek.Domain.Models.Inventories;
using Dukkantek.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Dukkantek.API
{
	public class DBSeeder
	{

		public static void Seed(DukkantekDbContext context)
		{
			// context.Database.EnsureCreated() does not use migrations to create the database and therefore the database that is created cannot be later updated using migrations 
			// use context.Database.Migrate() instead
			context.Database.Migrate();

			if (context.Categories.Any() && context.Products.Any())
			{
				return;
			}

			// insert dummy data
			context.AddRange(GetDummyCategoryList());
			context.AddRange(GetDummyProductList());
			context.SaveChanges();
		}


		public static List<Category> GetDummyCategoryList()
		{

			var categories = new List<Category> {
			new Category{ Name = "Kitchen"},
			new Category{ Name = "Washroom"},
			new Category{ Name = "Bedroom"},
			new Category{ Name = "Garden"},

			};

			return categories;
		}
		public static List<Product> GetDummyProductList()
			{
			var products = new List<Product> {
			new Product{ Name = "Dinner Set", Barcode = "7333250", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333251", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333252", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333253", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333254", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333255", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333256", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333257", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333258", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 1},
			new Product{ Name = "Dinner Set", Barcode = "7333259", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Damaged, CategoryId = 1},

			new Product{ Name = "Washroom Set", Barcode = "7333260", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333261", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333262", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333263", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333264", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333265", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Damaged, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333266", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333267", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333268", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Damaged, CategoryId = 2},
			new Product{ Name = "Washroom Set", Barcode = "7333269", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 2},

			new Product{ Name = "Badroom Set", Barcode = "7333270", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333271", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Damaged, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333272", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333273", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333274", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333275", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333276", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333277", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333278", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.Sold, CategoryId = 3},
			new Product{ Name = "Badroom Set", Barcode = "7333279", Description = "12 set Dinner Set" , Weight = 1380, Status = Status.InStock, CategoryId = 3},

		};

			return products;
		}
	}
}
