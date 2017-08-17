﻿﻿using System.Data.Entity;
using Web.Data;
using Web.Migrations;

namespace Web
{
	public static class EFConfig
	{
		public static void Initialize()
		{
			Database.SetInitializer(
				new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
		}
	}
}