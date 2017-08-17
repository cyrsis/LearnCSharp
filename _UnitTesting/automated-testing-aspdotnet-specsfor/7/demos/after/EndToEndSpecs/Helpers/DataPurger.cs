﻿using SpecsFor;
using SpecsFor.Configuration;
using SpecsFor.Mvc;
using Web.Data;

namespace EndToEndSpecs.Helpers
{
	public class DataPurger : Behavior<SpecsFor<MvcWebApp>>
	{
		public override void SpecInit(SpecsFor<MvcWebApp> instance)
		{
			using (var context = new AppDbContext())
			{
				//Disable all foreign keys.
				context.Database
					.ExecuteSqlCommand("EXEC sp_msforeachtable \"ALTER TABLE ? NOCHECK CONSTRAINT all\"");
				//Remove all data from tables EXCEPT for the EF Migration History table!
				context.Database
					.ExecuteSqlCommand("EXEC sp_msforeachtable \"IF '?' != '[dbo].[__MigrationHistory]' DELETE FROM ?\"");
				//Turn FKs back on
				context.Database
					.ExecuteSqlCommand("EXEC sp_msforeachtable \"ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all\"");
			}
		}
	}
}