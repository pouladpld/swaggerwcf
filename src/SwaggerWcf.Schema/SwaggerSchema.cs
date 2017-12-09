﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// This is the root document object for the API specification. It combines what previously was the Resource Listing and API Declaration (version 1.2 and earlier) together into one document.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public sealed class SwaggerSchema
    {
        /// <summary>
        /// Required. Specifies the Swagger Specification version being used. It can be used by the Swagger UI and other clients to interpret the API listing. The value MUST be "2.0".
        /// </summary>
        [JsonRequired]
        public string Swagger = "2.0";

        /// <summary>
        /// Required. Provides metadata about the API. The metadata can be used by the clients if needed.
        /// </summary>
        [JsonRequired]
        public Info Info;

        /// <summary>
        /// The host (name or ip) serving the API. This MUST be the host only and does not include the scheme
        /// nor sub-paths. It MAY include a port. If the host is not included, the host serving the documentation
        /// is to be used (including the port). The host does not support path templating.
        /// </summary>
        public string Host;

        /// <summary>
        /// The base path on which the API is served, which is relative to the host. If it is not included,
        /// the API is served directly under the host. The value MUST start with a leading slash (/). The
        /// basePath does not support path templating.
        /// </summary>
        public string BasePath;

        /// <summary>
        /// The transfer protocol of the API. Values MUST be from the list: "http", "https", "ws", "wss". If
        /// the schemes is not included, the default scheme to be used is the one used to access the Swagger
        /// definition itself.
        /// </summary>
        public IEnumerable<Scheme> Schemes;

        /// <summary>
        /// A list of MIME types the APIs can consume. This is global to all APIs but can be overridden on
        /// specific API calls. Value MUST be as described under Mime Types.
        /// </summary>
        public string[] Consumes;

        /// <summary>
        /// A list of MIME types the APIs can produce. This is global to all APIs but can be overridden on
        /// specific API calls. Value MUST be as described under Mime Types.
        /// </summary>
        public string[] Produces { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, PathItem> Paths { get; set; }

        //public IEnumerable<Definition> Definitions { get; set; }

        //public SecurityDefinitions SecurityDefinitions { get; set; }

        /// <summary>
        /// A list of tags used by the specification with additional metadata. The order of the tags can be used to reflect on their order by the parsing tools. Not all tags that are used by the Operation Object must be declared. The tags that are not declared may be organized randomly or based on the tools' logic. Each tag name in the list MUST be unique.
        /// </summary>
        public Tag[] Tags;

        /// <summary>
        /// Additional external documentation.
        /// </summary>
        public ExternalDocumentation ExternalDocs;
    }
}