using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// License information for the exposed API.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class License
    {
        /// <summary>
        /// Required. The license name used for the API.
        /// </summary>
        [JsonRequired]
        public string Name;

        /// <summary>
        /// A URL to the license used for the API. MUST be in the format of a URL.
        /// </summary>
        public string Url
        {
            get => _url;
            set => _url = Uri.TryCreate(value, UriKind.Absolute, out Uri _)
                    ? value
                    : throw new ArgumentException("Value must be in the format of a URL", nameof(Url));
        }

        private string _url;
    }
}
