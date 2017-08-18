using Microsoft.Ajax.Samples;
using Sixeyed.CarValet.Services.ResponseHeaders;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Sixeyed.CarValet.Services
{
   [ServiceContract]
    public class RestVehicleService 
    {
       [OperationContract]
       [WebGet(UriTemplate="/makes/startsWith={startsWith}", ResponseFormat=WebMessageFormat.Json)]
       [JSONPBehavior(callback="callback")]
       public IEnumerable<string> SearchMakes(string startsWith)
       {
           var makes = new VehicleService().SearchMakes(startsWith);

          // Expires.Set(20);

           var eTag = ETag.Compute(makes);
           ETag.Set(eTag);
           ETag.CheckNotModified(eTag);

           return makes;
       }
    }
}
