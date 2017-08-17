﻿using System;
using System.Data.Entity;
using System.IO;
using SpecsFor;
using SpecsFor.Configuration;
using SpecsFor.Mvc;
using Web.Data;

namespace EndToEndSpecs.Helpers
{
	public class EndToEndDatabaseCreator : Behavior<SpecsFor<MvcWebApp>>
	{
		//TODO: Decide if we should be doing this, or re-running every time??
		private static bool _isInitialized;

		public override void SpecInit(SpecsFor<MvcWebApp> instance)
		{
			if (_isInitialized) return;

			AppDomain.CurrentDomain.SetData("DataDirectory",
				Directory.GetCurrentDirectory());

			var strategy = new DropCreateDatabaseAlways<AppDbContext>();
			Database.SetInitializer(strategy);

			using (var context = new AppDbContext())
			{
				context.Database.Initialize(force: true);
			}

			_isInitialized = true;

		}
	}
}