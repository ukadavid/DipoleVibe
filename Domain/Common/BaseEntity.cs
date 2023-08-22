using System;
namespace Domain.Common
{
	public abstract class BaseEntity
	{
		// The Id is a common field so it can be reuseable
		public virtual Guid Id { get; set; }
	}
}

