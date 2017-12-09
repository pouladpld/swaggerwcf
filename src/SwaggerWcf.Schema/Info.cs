using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// The object provides metadata about the API. The metadata can be used by the clients if needed, and can be presented in the Swagger-UI for convenience.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Info
    {
        /// <summary>
        /// Required. The title of the application.
        /// </summary>
        [JsonRequired]
        public string Title;

        /// <summary>
        /// Required Provides the version of the application API (not to be confused with the specification version).
        /// </summary>
        [JsonRequired]
        public string Version;

        /// <summary>
        /// A short description of the application. GFM syntax can be used for rich text representation.
        /// </summary>
        public string Description;

        /// <summary>
        /// The Terms of Service for the API.
        /// </summary>
        public string TermsOfService;

        /// <summary>
        /// The license information for the exposed API.
        /// </summary>
        public License License;

        /// <summary>
        /// The contact information for the exposed API.
        /// </summary>
        public Contact Contact;
    }
}
