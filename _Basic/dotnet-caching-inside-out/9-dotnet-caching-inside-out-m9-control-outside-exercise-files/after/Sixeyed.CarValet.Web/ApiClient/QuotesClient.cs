using Newtonsoft.Json;
using Sixeyed.CarValet.Api.Models;
using System.Collections.Generic;
using System.Net;
using Sixeyed.Core.Extensions;
using System.Configuration;

namespace Sixeyed.CarValet.Web.ApiClient
{
    public static class QuotesClient
    {
        public static IEnumerable<QuoteModel> GetQuotes(int vehicleId, string postalCode)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString(ConfigurationManager.AppSettings["ApiRootUrl"] + "/api/quotes?vehicleId={0}&postalCode={1}".FormatWith(vehicleId, postalCode));
                return JsonConvert.DeserializeObject<List<QuoteModel>>(json);
            }
        }
    }
}