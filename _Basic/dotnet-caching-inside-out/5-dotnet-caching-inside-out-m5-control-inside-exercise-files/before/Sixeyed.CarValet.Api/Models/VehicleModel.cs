using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sixeyed.CarValet.Api.ServiceAgents.Wcf.Vehicle;

namespace Sixeyed.CarValet.Api.Models
{
    public class VehicleModel
    {
        public int VehicleId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public DateTime ProducedFromUtc { get; set; }

        public DateTime? ProducedToUtc { get; set; }

        public static VehicleModel FromServiceEntity(Vehicle vehicle)
        {
            return new VehicleModel()
            {
                VehicleId = vehicle.VehicleId,
                ImageUrl = vehicle.ImageUrl,
                Make = vehicle.Make,
                Model = vehicle.Model,
                Name = vehicle.Name,
                ProducedFromUtc = vehicle.ProducedFromUtc,
                ProducedToUtc = vehicle.ProducedToUtc
            };
        }
    }
}