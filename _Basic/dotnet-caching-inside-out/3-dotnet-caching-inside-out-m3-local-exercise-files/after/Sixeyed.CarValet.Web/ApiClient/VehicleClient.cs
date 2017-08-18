using Newtonsoft.Json;
using Sixeyed.CarValet.Api.Models;
using System.Collections.Generic;
using System.Net;
using Sixeyed.Core.Extensions;
using System.Configuration;

namespace Sixeyed.CarValet.Web.ApiClient
{
    public static class VehicleClient
    {
        public static VehicleModel GetById(int vehicleId)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString(ConfigurationManager.AppSettings["ApiRootUrl"] + "/api/vehicle/{0}".FormatWith(vehicleId));
                return JsonConvert.DeserializeObject<VehicleModel>(json);
            }
        }
    }
}