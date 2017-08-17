﻿﻿using System;
using System.Data.Entity;
using System.IO;
using SpecsFor.Configuration;
using Web.Data;
using Web.Migrations;

namespace IntegrationSpecs.TestHelpers
{
	public class EFDatabaseCreator : Behavior<INeedDatabase>
	{
		private static bool _isInitialized;

		public override void SpecInit(INeedDatabase instance)
		{
			if (_isInitialized) return;

			AppDomain.CurrentDomain.SetData("DataDirectory",
				Directory.GetCurrentDirectory());

			var strategy =
				new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>();
			Database.SetInitializer(strategy);

			using (var context = new AppDbContext())
			{
				context.Database.Initialize(force: true);
			}

			_isInitialized = true;

		}
	}
}