using System;
using Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
	public interface IApplicationDbContext
	{
		DbSet<AppSetting> AppSettings { get; set; }
		Task<int> SaveChangesAsync();
	}
}

