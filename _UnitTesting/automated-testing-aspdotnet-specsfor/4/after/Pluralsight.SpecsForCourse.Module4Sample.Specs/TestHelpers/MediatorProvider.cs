using SpecsFor;
using SpecsFor.Configuration;
using Web.Infrastructure;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers
{
	public interface INeedMediator : ISpecs
	{
		
	}

	public class MediatorProvider : Behavior<INeedMediator>
	{
		public override void SpecInit(INeedMediator instance)
		{
			instance.MockContainer.Configure(cfg => cfg.AddRegistry(new MediatorRegistry()));
		}
	}
}