using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
	public class StockContext:DbContext
	{
		public DbSet<Stock> Stock{ get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("server=localhost;user id=root;persistsecurityinfo=True;sslmode=None;port=49156;database=sys;password=olist123", new MySqlServerVersion(new Version()));
		}
	}
}
