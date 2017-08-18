using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sixeyed.CarValet.Services.ResponseHeaders;

namespace Sixeyed.CarValet.Services
{
   [ServiceContract]
    public class RestVehicleService 
    {
       [OperationContract]
       [WebGet(UriTemplate="/makes/startsWith={startsWith}", ResponseFormat=WebMessageFormat.Json)]
       public IEnumerable<string> SearchMakes(string startsWith)
       {
           var makes = new VehicleService().SearchMakes(startsWith);

           Expires.Set(30);

           var eTag = ETag.Compute(makes);
           ETag.Set(eTag);
           ETag.CheckNotModified(eTag);

           return makes;
       }
    }
}
