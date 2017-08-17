﻿﻿using System.Data.Entity;
using Web.Core;

namespace Web.Data
{
	public class AppDbContext : DbContext
	{
		public IDbSet<Task> Tasks { get; set; }

		public AppDbContext()
			: base("DefaultConnection")
		{

		}
	}
}