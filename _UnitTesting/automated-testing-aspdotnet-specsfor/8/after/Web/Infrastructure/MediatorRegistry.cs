using MediatR;
using Microsoft.Practices.ServiceLocation;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Web.Infrastructure
{
	public class MediatorRegistry : Registry
	{
		public MediatorRegistry()
		{
			For<ServiceLocatorProvider>().Use(x => new ServiceLocatorProvider(() => new StructureMapServiceLocator(x.GetInstance<IContainer>())));
			For<IMediator>().Use<Mediator>();
			Scan(scanner =>
			{
				scanner.TheCallingAssembly();
				scanner.AssemblyContainingType<IMediator>();
				scanner.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<,>));
				scanner.ConnectImplementationsToTypesClosing(typeof(IAsyncRequestHandler<,>));
				scanner.ConnectImplementationsToTypesClosing(typeof(INotificationHandler<>));
				scanner.ConnectImplementationsToTypesClosing(typeof(IAsyncNotificationHandler<>));
			});
		}
	}
}