using StructureMap;
using Web.Infrastructure;

namespace Web
{
	public static class MediatorConfig
	{
		public static void Configure(IContainer container)
		{
			container.Configure(cfg =>
			{
				cfg.AddRegistry(new MediatorRegistry());
			});
		}
	}
}