using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace Sixeyed.CarValet.Services.ResponseHeaders
{
    public static class ETag
    {
        public static void Set(Guid eTag)
        {
            var response = WebOperationContext.Current.OutgoingResponse;
            if (response != null)
            {
                response.SetETag(eTag);
            }
        }

        public static void CheckNotModified(Guid eTag)
        {
            var request = WebOperationContext.Current.IncomingRequest;
            if (request.Method == "GET" || request.Method == "HEAD")
            {
                request.CheckConditionalRetrieve(eTag);
            }
        }

        public static Guid Compute(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return GetDeterministicGuid(json);
        }

        private static Guid GetDeterministicGuid(string input)
        {
            var provider = new MD5CryptoServiceProvider();
            var inputBytes = Encoding.Default.GetBytes(input);
            var hashBytes = provider.ComputeHash(inputBytes);
            return new Guid(hashBytes);
        }
    }
}