using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System.Diagnostics;

// ReSharper disable All

namespace Enriched.MvcExtensions
{
    public static class HttpContextExtensions
    {
        public static string GetRequestId(this HttpContext httpContext)
        {
            return Activity.Current?.Id ?? httpContext.TraceIdentifier;
        }

        public static IHttpConnectionFeature GetHttpConnectionFeature(this HttpContext context)
        {
            return context.Features.Get<IHttpConnectionFeature>();
        }
    }
}