using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Accountant.Api.Middleware
{
    public class HeaderValidatorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public HeaderValidatorMiddleware(RequestDelegate next, 
            ILogger<HeaderValidatorMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation($"Validating HTTP headers...");
            if(context.Request.Headers.Any(x => x.Key == "test"))
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                var json = JsonConvert.SerializeObject(new {message = "Invalid header"});
                await context.Response.WriteAsync(json);
                return;
            }
            await _next(context);
        }        
    }
}