using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// The transfer protocol of the API. Values MUST be from the list: "http", "https", "ws", "wss". If the schemes is not included, the default scheme to be used is the one used to access the Swagger definition itself.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum Scheme
    {
        /// <summary>
        /// HTTP Scheme
        /// </summary>
        Http,

        /// <summary>
        /// HTTPS Scheme
        /// </summary>
        Https,

        /// <summary>
        /// WS Scheme
        /// </summary>
        Ws,

        /// <summary>
        /// WSS Scheme
        /// </summary>
        Wss
    }
}