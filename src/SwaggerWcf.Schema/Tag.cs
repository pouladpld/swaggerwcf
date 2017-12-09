using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// Allows adding meta data to a single tag that is used by the Operation Object. It is not mandatory to have a Tag Object per tag used there.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Tag
    {
        /// <summary>
        /// Required. The name of the tag.
        /// </summary>
        [JsonRequired]
        public string Name;

        /// <summary>
        /// A short description for the tag. GFM syntax can be used for rich text representation.
        /// </summary>
        public string Description;

        /// <summary>
        /// Additional external documentation for this tag.
        /// </summary>
        public ExternalDocumentation ExternalDocs;
    }
}
