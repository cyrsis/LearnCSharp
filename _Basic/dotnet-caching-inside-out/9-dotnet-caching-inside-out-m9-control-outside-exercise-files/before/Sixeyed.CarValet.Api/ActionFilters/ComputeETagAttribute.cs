using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http.Filters;

namespace Sixeyed.CarValet.Api.ActionFilters
{
    public class ComputeETagAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var serverETag = ComputeAndSetETag(actionExecutedContext.Response);
            var clientETag = string.Empty;
            var eTagHeader = actionExecutedContext.Request.Headers.IfNoneMatch.FirstOrDefault();
            if (eTagHeader != null)
            {
                clientETag = eTagHeader.Tag;
            }
            if (!string.IsNullOrEmpty(clientETag) && clientETag == serverETag)
            {
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.NotModified);
            }
        }

        private string ComputeAndSetETag(HttpResponseMessage response)
        {
            string eTag = null;
            object responseObject;
            response.TryGetContentValue(out responseObject);
            if (responseObject != null)
            {
                var json = JsonConvert.SerializeObject(responseObject);
                eTag = string.Format(@"""{0}""", GetDeterministicGuid(json));
                SetETagHeader(response, eTag);
            }
            return eTag;
        }

        private static void SetETagHeader(HttpResponseMessage message, string eTag)
        {
            message.Headers.ETag = new EntityTagHeaderValue(eTag, false);
            //ES - for Cassini, http://stackoverflow.com/questions/32824/why-does-httpcacheability-private-suppress-etags
            message.Headers.CacheControl = new CacheControlHeaderValue();
            if (!message.Headers.Vary.Contains("Accept"))
            {
                message.Headers.Vary.Add("Accept");
            }
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