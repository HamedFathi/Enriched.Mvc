using System.Collections.Generic;

// ReSharper disable CheckNamespace

namespace Enriched.Mvc
{
    public class UnavailableApiVersion
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> AvailableVersions { get; set; }
        public IEnumerable<string> DeprecatedVersions { get; set; }

        public UnavailableApiVersion()
        {
            AvailableVersions = new List<string>();
            DeprecatedVersions = new List<string>();
        }
    }
}