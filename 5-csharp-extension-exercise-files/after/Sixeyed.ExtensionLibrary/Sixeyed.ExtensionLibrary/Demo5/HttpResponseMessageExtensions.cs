
namespace System.Net.Http
{
    public static class HttpResponseMessageExtensions
    {
        public static void AddLocationHeader(this HttpResponseMessage response, HttpRequestMessage request, int entityId)
        {
            var url = string.Format("{0}/{1}", request.RequestUri, entityId);
            response.Headers.Location = new Uri(url);
        }
    }
}
