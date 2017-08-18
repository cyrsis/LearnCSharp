using Newtonsoft.Json;
using Sixeyed.CarValet.Api.Models;
using Sixeyed.Core.Containers;
using Sixeyed.Core.Containers.Interception.Cache;
using Sixeyed.Core.Logging;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace Sixeyed.CarValet.Web.ApiClient
{
    public class ContentClient
    {
        static ContentClient()
        {
            Container.Register<ContentClient>(Lifetime.Singleton);
        }

        public static IEnumerable<ContentModel> GetItems(string contentCode)
        {
            return Container.Get<ContentClient>().GetItemsInternal(contentCode);
        }

        [Cache]
        protected virtual IEnumerable<ContentModel> GetItemsInternal(string contentCode)
        {
            Log.Debug("ContentClient.GetItems called for contentCode: {0}", contentCode);
            using (var client = new WebClient())
            {
                var json = client.DownloadString(ConfigurationManager.AppSettings["ApiRootUrl"] + "/api/content?contentCode=" + contentCode);
                var items = JsonConvert.DeserializeObject<List<ContentModel>>(json);
                Log.Debug("ContentClient.GetItems returning: {0} items for contentCode: {1}", items.Count, contentCode);
                return items;
            }
        }
    }
}