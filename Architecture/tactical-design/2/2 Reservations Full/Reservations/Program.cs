using Microsoft.Practices.Unity;
using System;

namespace Reservations
{
    class Program
    {

        static IUnityContainer InitializeIoCContainer()
        {
            return
                new UnityContainer()
                .RegisterType<Application, Application>()
                .RegisterType<IVacationPartFactory, VacationPartFactory>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IHotelSelector, HotelSelector>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IHotelService, HotelService>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IAirplaneService, AirplaneService>(
                    new ContainerControlledLifetimeManager());
        }

        static void Main(string[] args)
        {

            InitializeIoCContainer()
                .Resolve<Application>()
                .Run();
            Console.ReadLine();

        }
    }
}
