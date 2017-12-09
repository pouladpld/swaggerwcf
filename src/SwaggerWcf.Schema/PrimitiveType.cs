using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// Primitive data types in JSON Schema.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum PrimitiveType
    {
        /// <summary>
        /// Null
        /// </summary>
        Null,

        /// <summary>
        /// Boolean
        /// </summary>
        Boolean,

        /// <summary>
        /// Object
        /// </summary>
        Object,

        /// <summary>
        /// Array
        /// </summary>
        Array,

        /// <summary>
        /// Float or Double precision number
        /// </summary>
        Number,

        /// <summary>
        /// String
        /// </summary>
        String,

        /// <summary>
        /// Signed 32 or 64 bits number with a zero fractional part
        /// </summary>
        Integer,
    }
}
