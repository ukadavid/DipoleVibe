using System;
using Application.Common.Interfaces;
using Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<AppSetting> AppSettings { get; set; }

		public Task<int> SaveChangesAsync()
		{
			return base.SaveChangesAsync();
		}
	}
}

