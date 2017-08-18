using Sixeyed.CarValet.Services.Entities;
using Sixeyed.CarValet.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using data = Sixeyed.CarValet.Entities;

namespace Sixeyed.CarValet.Services
{
    [ServiceContract]
    public class VehicleService
    {
        [OperationContract]
        public IEnumerable<string> SearchMakes(string startsWith)
        {
            var makeNames = new List<string>();
            startsWith = startsWith.Trim().ToLower();
            if (startsWith.Length > 0)
            {
                makeNames.AddRange(Repository.Vehicle.GetMakes()
                                    .Where(m => m.MakeNameLower.StartsWith(startsWith))
                                    .Select(x => x.MakeName));
            }
            return makeNames;
        }

        [OperationContract]
        public IEnumerable<string> SearchModels(string makeName, string startsWith)
        {
            var modelNames = new List<string>();
            startsWith = startsWith.Trim().ToLower();
            if (makeName.Length > 0 && startsWith.Length > 0)
            {
                modelNames.AddRange(Repository.Vehicle.GetModels(makeName)
                                     .Where(x => x.ModelNameLower.StartsWith(startsWith))
                                     .Select(x => x.ModelName));
            }
            return modelNames;
        }

        [OperationContract]
        public IEnumerable<Vehicle> GetByMakeAndModel(string makeName, string modelName)
        {
            var vehicles = Repository.Vehicle.GetVehicles(makeName, modelName);
            return vehicles.ConvertAll<Vehicle>(new Converter<data.Vehicle, Vehicle>(Vehicle.FromEntity));
        }

        [OperationContract]
        public Vehicle GetById(int vehicleId)
        {
            var vehicle = Repository.Vehicle.GetVehicle(vehicleId);
            return Vehicle.FromEntity(vehicle);
        }
    }
}