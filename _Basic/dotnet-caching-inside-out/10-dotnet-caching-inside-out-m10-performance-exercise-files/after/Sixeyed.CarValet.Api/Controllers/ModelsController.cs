using Sixeyed.CarValet.Api.ActionFilters;
using Sixeyed.CarValet.Api.ServiceAgents;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Sixeyed.CarValet.Api.Controllers
{
    public class ModelsController : ApiController
    {
        //7 days in private cache, 1 day in public cache:
        [CacheControl(MaxAgeSeconds = 604800, SharedMaxAgeSeconds = 86400)]
        [ComputeETag]
        public IEnumerable<string> GetByName(string makeName, string startsWith)
        {
            var response = ServiceAgent.Vehicle.SearchModels(makeName, startsWith);
            var models = new List<string>(response);
            if (models.Count == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return models;
        }
    }
}