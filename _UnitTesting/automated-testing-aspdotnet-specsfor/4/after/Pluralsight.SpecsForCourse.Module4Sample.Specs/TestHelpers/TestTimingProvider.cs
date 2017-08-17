using System;
using System.Diagnostics;
using SpecsFor;
using SpecsFor.Configuration;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers
{
	public class TestTimingProvider : Behavior<ISpecs>
	{
		private Stopwatch _stopwatch;

		public override void SpecInit(ISpecs instance)
		{
			_stopwatch = Stopwatch.StartNew();
		}

		public override void AfterSpec(ISpecs instance)
		{
			Console.WriteLine(instance.GetType().FullName + " - " + _stopwatch.Elapsed);
		}
	}
}