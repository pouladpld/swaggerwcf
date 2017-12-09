using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// Allows referencing an external resource for extended documentation
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ExternalDocumentation
    {
        /// <summary>
        /// Required. The URL for the target documentation. Value MUST be in the format of a URL.
        /// </summary>
        [JsonRequired]
        public string Url
        {
            get => _url;
            set => _url = Uri.TryCreate(value, UriKind.Absolute, out Uri _)
                ? value
                : throw new ArgumentException("Value must be in the format of a URL", nameof(Url));
        }

        /// <summary>
        /// A short description of the target documentation. GFM syntax can be used for rich text representation.
        /// </summary>
        public string Description;

        private string _url;
    }
}