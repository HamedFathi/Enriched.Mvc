// ReSharper disable CheckNamespace
namespace Enriched.MvcMiddlewares
{
    public class CorrelationIdOptions
    {
        public string Key { get; set; } = "X-Correlation-Id";
        public bool IncludeInResponseHeader { get; set; } = true;
        public bool IncludeInUserClaim { get; set; } = true;
    }
}