using Sixeyed.CarValet.Api.ActionFilters;
using Sixeyed.CarValet.Api.ServiceAgents;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Sixeyed.CarValet.Api.Controllers
{
    public class MakesController : ApiController
    {
        [Expires(Seconds=120)]
        public IEnumerable<string> GetByName(string startsWith)
        {
            var response = ServiceAgent.Vehicle.SearchMakes(startsWith);
            var makes = new List<string>(response);
            if (makes.Count == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return makes;
        }
    }
}