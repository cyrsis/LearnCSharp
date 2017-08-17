﻿﻿using SpecsFor.Configuration;
using Web.Data;

namespace IntegrationSpecs.TestHelpers
{
	public class EFContextFactory : Behavior<INeedDatabase>
	{
		public override void SpecInit(INeedDatabase instance)
		{
			instance.Database = new AppDbContext();

			instance.MockContainer
				.Configure(cfg => cfg.For<AppDbContext>().Use(instance.Database));
		}

		public override void AfterSpec(INeedDatabase instance)
		{
			instance.Database.Dispose();
		}
	}
}