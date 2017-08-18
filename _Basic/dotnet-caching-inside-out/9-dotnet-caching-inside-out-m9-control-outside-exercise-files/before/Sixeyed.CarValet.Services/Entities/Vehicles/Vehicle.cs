using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data = Sixeyed.CarValet.Entities;
using System.Runtime.Serialization;

namespace Sixeyed.CarValet.Services.Entities
{
    [DataContract]
    public class Vehicle
    {
        [DataMember]
        public int VehicleId { get; set; }

        [DataMember]
        public string Make { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public DateTime ProducedFromUtc { get; set; }

        [DataMember]
        public DateTime? ProducedToUtc { get; set; }

        public static Vehicle FromEntity(data.Vehicle vehicle)
        {
            return new Vehicle()
            {
                VehicleId = vehicle.VehicleId,
                ImageUrl = vehicle.ImageUrl,
                Make = vehicle.Model.Make.MakeName,
                Model = vehicle.Model.ModelName,
                Name = vehicle.Name,
                ProducedFromUtc = vehicle.ProducedFromUtc,
                ProducedToUtc = vehicle.ProducedToUtc
            };
        }
    }
}