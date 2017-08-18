using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sixeyed.CarValet.Entities.Tests
{
    [TestClass]
    public class DataLoader
    {
        private static Random _Random = new Random();

        [TestMethod]
        public void LoadVehicles()
        {
            using (var entities = new VehicleEntities())
            {
                var modernVehicle = entities.VehicleTypes.FirstOrDefault(x => x.TypeCode == "MDN");
                var classicVehicle = entities.VehicleTypes.FirstOrDefault(x => x.TypeCode == "CLASS");
                foreach (var model in entities.Models)
                {
                    if (model.Vehicles.Count == 0)
                    {
                        var vehicle = new Vehicle();
                        vehicle.Model = model;
                        vehicle.ImageUrl = string.Format("http://cdn.carvalet.com/img/veh/{0}_{1}_1.png", model.MakeCode, model.ModelCode);
                        vehicle.Name = model.ModelName + " v1";
                        vehicle.ProducedFromUtc = new DateTime(_Random.Next(1970, 2008), 01, 01);
                        vehicle.ProducedToUtc = _Random.Next() % 2 == 0 ? new DateTime?(vehicle.ProducedFromUtc.AddYears(_Random.Next(0, 5))) : null;
                        vehicle.VehicleType = vehicle.ProducedFromUtc.Year < 1980 ? classicVehicle : modernVehicle;
                        entities.Vehicles.Add(vehicle);
                    }
                }
                entities.SaveChanges();
            }
        }

        [TestMethod]
        public void LoadPostalCodePricingFactors()
        {
            using (var entities = new PricingEntities())
            {
                var postalCodeFactor = entities.PricingFactorTypes.Single(x => x.PricingFactorTypeCode == "POC");
                var postalCodes = "ABCDEFGHJKLMNOPRSTUVWY";
                foreach (var firstLetter in postalCodes)
                {
                    foreach (var secondLetter in postalCodes)
                    {
                        for (var i = 1; i <= _Random.Next(2, 6); i++)
                        {
                            var factor = new PricingFactor();
                            factor.PricingFactorType = postalCodeFactor;
                            factor.AppliesTo = string.Format("{0}{1}{2}", firstLetter, secondLetter, i);
                            factor.Factor = _Random.NextDouble() + _Random.NextDouble();
                            entities.PricingFactors.Add(factor);
                        }
                    }
                }
                entities.SaveChanges();
            }
        }

        [TestMethod]
        public void LoadVehiclePricingFactors()
        {
            int minVehicleId, maxVehicleId;
            using (var vehicleEntities = new VehicleEntities())
            {
                minVehicleId = vehicleEntities.Vehicles.Min(x => x.VehicleId);
                maxVehicleId = vehicleEntities.Vehicles.Max(x => x.VehicleId);
            }

            using (var entities = new PricingEntities())
            {
                var vehicleFactor = entities.PricingFactorTypes.Single(x => x.PricingFactorTypeCode == "VID");
                for (var vehicleId = minVehicleId; vehicleId <= maxVehicleId; vehicleId++)
                {
                    var factor = new PricingFactor();
                    factor.PricingFactorType = vehicleFactor;
                    factor.AppliesTo = vehicleId.ToString();
                    factor.Factor = _Random.NextDouble() + _Random.NextDouble();
                    entities.PricingFactors.Add(factor);
                }
                entities.SaveChanges();
            }
        }
    }
}
