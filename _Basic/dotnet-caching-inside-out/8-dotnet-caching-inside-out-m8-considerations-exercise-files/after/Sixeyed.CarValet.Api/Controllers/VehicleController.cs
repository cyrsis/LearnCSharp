using Sixeyed.CarValet.Api.ActionFilters;
using Sixeyed.CarValet.Api.Models;
using Sixeyed.CarValet.Api.ServiceAgents;
using Sixeyed.CarValet.Api.ServiceAgents.Wcf.Vehicle;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Sixeyed.CarValet.Api.Controllers
{
    public class VehicleController : ApiController
    {
        public IEnumerable<VehicleModel> GetByMakeAndModel(string makeName, string modelName)
        {
            var response = ServiceAgent.Vehicle.GetByMakeAndModel(makeName, modelName);
            var vehicles = new List<Vehicle>(response);
            if (vehicles.Count == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }            
            return vehicles.ConvertAll<VehicleModel>(new Converter<Vehicle, VehicleModel>(VehicleModel.FromServiceEntity));
        }

        [Expires(Seconds=30)]
        public VehicleModel GetById(int id)
        {
            var vehicle = ServiceAgent.Vehicle.GetById(id);
            if (vehicle == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return VehicleModel.FromServiceEntity(vehicle);
        }
    }
}