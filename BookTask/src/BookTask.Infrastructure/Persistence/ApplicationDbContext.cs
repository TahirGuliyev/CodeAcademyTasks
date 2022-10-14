using BookTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask.Infrastructure.Persistence;

public class ApplicationDbContext:DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
	{

	}
		public DbSet<Book> Book { get; set; }
		public DbSet<Review> Review { get; set; }
		public DbSet<Vendor> Vendor { get; set; }
}
