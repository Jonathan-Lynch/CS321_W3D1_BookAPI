using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Book> Books { get; set; }

		public DbSet<Author> Authors { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder myBuilder)
		{
			myBuilder.UseSqlite("Data Source=Books.db");
		}

		protected override void OnModelCreating(ModelBuilder myModelBuilder)
		{
			base.OnModelCreating(myModelBuilder);

			myModelBuilder.Entity<Book>().HasData(
				new Book { Id = 1, Title = "The Great Divorce", AuthorId = 1, Category = "Theology", },
				new Book { Id = 2, Title = "Tilt-A-Whirl", AuthorId = 2, Category = "Theology" },
				new Book { Id = 3, Title = "The Holiness of God", AuthorId = 3, Category = "Theology" }

				);
			myModelBuilder.Entity<Author>().HasData(
				new Author { Id = 1, firstName = "Clive", lastName = "Lewis", birthday = new DateTime(1819, 11, 29)},
				new Author { Id = 2, firstName = "Nathan", lastName = "Wilson", birthday = new DateTime(1978, 1, 1)},
				new Author { Id = 3, firstName = "Robert", lastName = "Sproul", birthday = new DateTime(1939, 2, 13)}

				);
		}
	}
}
