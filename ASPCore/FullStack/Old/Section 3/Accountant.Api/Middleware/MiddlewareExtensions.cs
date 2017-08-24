using Microsoft.AspNetCore.Builder;

namespace Accountant.Api.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLog(this IApplicationBuilder builder)
        => builder.UseMiddleware<RequestLogMiddleware>();
        
        public static IApplicationBuilder UseHeaderValidator(this IApplicationBuilder builder)
        => builder.UseMiddleware<HeaderValidatorMiddleware>();        
    }
}