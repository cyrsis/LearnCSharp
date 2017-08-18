using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Web;
using Sixeyed.CarValet.Services.Extensions;

namespace Sixeyed.CarValet.Services.ResponseHeaders
{
    public static class Expires
    {
        public static void Set(int seconds)
        {
            var response = WebOperationContext.Current.OutgoingResponse;
            if (response != null)
            {
                var expires = DateTime.UtcNow.AddSeconds(seconds).ToExpiresString();
                response.Headers.Add(HttpResponseHeader.Expires, expires);
            }
        }
    }
}