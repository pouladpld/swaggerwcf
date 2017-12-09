using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// Primitive data types in the Swagger Specification are based on the types supported by the JSON-Schema Draft 4. Models are described using the Schema Object which is a subset of JSON Schema Draft 4.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum DataType
    {
        /// <summary>
        /// Signed 32 or 64 bits number with a zero fractional part
        /// </summary>
        Integer,

        /// <summary>
        /// Float or Double precision number
        /// </summary>
        Number,

        /// <summary>
        /// String
        /// </summary>
        String,

        /// <summary>
        /// Boolean
        /// </summary>
        Boolean,

        /// <summary>
        /// Primitive data type "file" is used by the Parameter Object and the Response Object to set the parameter type or the response as being a file.
        /// </summary>
        File
    }
}
