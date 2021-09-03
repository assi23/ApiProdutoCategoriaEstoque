using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
	public class CategoryContext : DbContext
	{
		public DbSet<Category> Category { get; set; }
		public DbSet<Product> Product { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"server=localhost;Database=postgres;Username=postgres;Persist Security Info=True;Password=olist123");
		}
	}
}
