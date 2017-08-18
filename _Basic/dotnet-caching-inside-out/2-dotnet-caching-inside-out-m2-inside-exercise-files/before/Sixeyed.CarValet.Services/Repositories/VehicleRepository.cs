using Sixeyed.CarValet.Entities;
using Sixeyed.Core.Logging;
using System.Collections.Generic;
using System.Linq;
using Sixeyed.Core.Extensions;
using Sixeyed.Core.Caching;

namespace Sixeyed.CarValet.Services.Repositories
{
    public class VehicleRepository : IRepository
    {
        public IEnumerable<Make> GetMakes()
        {
            Log.Debug("VehicleRepository.GetMakes called");
            var makes = new List<Make>();
            using (var context = new VehicleEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                makes.AddRange(context.Makes);
            }
            Log.Debug("VehicleRepository.GetMakes completed");
            return makes;
        }

        public IEnumerable<Model> GetModels(string makeName)
        {
            var models = new List<Model>();
            using (var context = new VehicleEntities())
            {
                var make = context.Makes.FirstOrDefault(m => m.MakeName == makeName);
                if (make != null)
                {
                    models.AddRange(make.Models);
                }
            }
            return models;
        }

        public List<Vehicle> GetVehicles(string makeName, string modelName)
        {
            var vehicles = new List<Vehicle>();
            using (var context = new VehicleEntities())
            {
                vehicles.AddRange(context.Vehicles.Include("Model")
                                                  .Include("Model.Make")
                    .Where(x => x.Model.ModelNameLower == modelName.Trim().ToLower() &&
                                x.Model.Make.MakeNameLower == makeName.Trim().ToLower()).ToList());
            }
            return vehicles;
        }

        public Vehicle GetVehicle(int id)
        {
            Vehicle vehicle = null;
            using (var context = new VehicleEntities())
            {
                vehicle = context.Vehicles.Include("Model")
                                          .Include("Model.Make")
                                          .FirstOrDefault(x => x.VehicleId == id);
            }
            return vehicle;
        }
    }
}