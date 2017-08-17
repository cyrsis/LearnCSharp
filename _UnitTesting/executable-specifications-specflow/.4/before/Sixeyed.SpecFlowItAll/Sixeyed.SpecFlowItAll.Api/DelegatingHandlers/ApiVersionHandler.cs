using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Sixeyed.SpecFlowItAll.Api.DelegatingHandlers
{
    public class ApiVersionHandler : DelegatingHandler
    {
        private static string _BuildNumber;
        private static string _VersionNumber;

        static ApiVersionHandler()
        {
            _BuildNumber = typeof(ApiVersionHandler).Assembly.GetName().Version.ToString();
            var parts = _BuildNumber.Split('.');
            _VersionNumber = string.Format("{0}.{1}", parts[0], parts[1]);
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>(t =>
            {
                HttpResponseMessage resp = t.Result;
                resp.Headers.Add(Header.Version, _VersionNumber);
                resp.Headers.Add(Header.Build, _BuildNumber);
                return resp;
            });
        }

        private struct Header
        {
            public const string Version = "x-api-version";
            public const string Build = "X-api-build";
        }
    }
}