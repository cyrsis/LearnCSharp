using Newtonsoft.Json;
using Sixeyed.CarValet.Api.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace Sixeyed.CarValet.Web.ApiClient
{
    public static class ContentClient
    {
        public static IEnumerable<ContentModel> GetItems(string contentCode)
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString(ConfigurationManager.AppSettings["ApiRootUrl"] + "/api/content?contentCode=" + contentCode);
                return JsonConvert.DeserializeObject<List<ContentModel>>(json);
            }
        }
    }
}