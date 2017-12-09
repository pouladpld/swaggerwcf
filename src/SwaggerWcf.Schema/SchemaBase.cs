using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// The Schema Object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. This object is based on the JSON Schema Specification Draft 4 and uses a predefined subset of it. On top of this subset, there are extensions provided by this specification to allow for more complete documentation.
    /// </summary>
    /// <remarks>
    /// Further information about the properties can be found in JSON Schema Core and JSON Schema Validation. Unless stated otherwise, the property definitions follow the JSON Schema specification as referenced here.
    /// </remarks>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SchemaBase
    //where TSchema : SchemaBase<TSchema> ToDo: Validate
    {
        /// <summary>
        /// Reference another value in JSON document.
        /// </summary>
        [JsonProperty("$ref")]
        public string Ref;

        /// <summary>
        /// Format to more finely define the data type being used
        /// </summary>
        public string Format;

        /// <summary>
        /// Title
        /// </summary>
        public string Title;

        /// <summary>
        /// Description in the form of GFM syntax can be used for rich text representation
        /// </summary>
        public string Description;

        /// <summary>
        /// This keyword can be used to supply a default JSON value associated with a particular schema. Unlike JSON Schema, the value MUST conform to the defined type for the Schema Object
        /// </summary>
        public SchemaBase Default; // ToDo: Use TSchema

        /// <summary>
        ///    The value of "multipleOf" MUST be a number, strictly greater than 0. A numeric instance is valid only if division by this keyword's value results in an integer.
        /// </summary>
        public uint? MultipleOf
        {
            get => _multipleOf > 0 ? _multipleOf : default(uint?);
            set => _multipleOf = value > 0
                ? value.Value
                : throw new ArgumentOutOfRangeException("The value MUST be a number, strictly greater than 0.");
        }

        /// <summary>
        /// An inclusive upper limit for a numeric instance.
        /// </summary>
        public double? Maximum;

        /// <summary>
        /// An exclusive upper limit for a numeric instance.
        /// </summary>
        public double? ExclusiveMaximum;

        /// <summary>
        /// An inclusive lower limit for a numeric instance.
        /// </summary>
        public double? Minimum;

        /// <summary>
        /// An exclusive lower limit for a numeric instance.
        /// </summary>
        public double? ExclusiveMinimum;

        /// <summary>
        /// The maximum length of a string instance is defined as the number of its characters
        /// </summary>
        public uint? MaxLength;

        /// <summary>
        /// The minimum length of a string instance is defined as the number of its characters
        /// </summary>
        public uint? MinLength;

        /// <summary>
        /// This string SHOULD be a valid regular expression, according to the ECMA 262 regular expression dialect. A string instance is considered  valid if the regular expression matches the instance successfully.
        /// </summary>
        public string Pattern;

        /// <summary>
        /// An array instance is valid against "maxItems" if its size is less than, or equal to, the value of this keyword.
        /// </summary>
        public uint? MaxItems;

        /// <summary>
        /// An array instance is valid against "minItems" if its size is greater than, or equal to, the value of this keyword.
        /// </summary>
        public uint? MinItems;

        /// <summary>
        /// If this keyword has boolean value false, the instance validates successfully.If it has boolean value true, the instance validates successfully if all of its elements are unique. Omitting this keyword has the same behavior as a value of false.
        /// </summary>
        public bool? UniqueItems;

        /// <summary>
        /// An object instance is valid against "maxProperties" if its number of properties is less than, or equal to, the value of this keyword.
        /// </summary>
        public uint? MaxProperties;

        /// <summary>
        /// An object instance is valid against "minProperties" if its number of properties is greater than, or equal to, the value of this keyword.
        /// </summary>
        public uint? MinProperties;

        /// <summary>
        /// The value of this keyword MUST be an array.  Elements of this array, if any, MUST be strings, and MUST be unique. An object instance is valid against this keyword if every item in the array is the name of a property in the instance. Omitting this keyword has the same behavior as an empty array.
        /// </summary>
        public string[] Required;

        /// <summary>
        /// The value of this keyword MUST be an array.  This array SHOULD have at least one element.Elements in the array SHOULD be unique. An instance validates successfully against this keyword if its value is equal to one of the elements in this keyword's array value. Elements in the array might be of any value, including null.
        /// </summary>
        public object[] Enum;

        /// <summary>
        /// The value of this keyword MUST be either a string or an array. If it is an array, elements of the array MUST be strings and MUST be unique. String values MUST be one of the six primitive types ("null", "boolean", "object", "array", "number", or "string"), or "integer" which matches any number with a zero fractional part. An instance validates if and only if the instance is in any of the sets listed for this keyword.
        /// </summary>
        /* ToDo: could be PrimitiveType or PrimitiveType[].
         * use Tuple<PrimitiveType, PrimitiveType[]> and JsonConverter(TupleConverter, types[])
         */
        public object Type;

        /* ToDo: other props
         * 
            items
            allOf
            properties
            additionalProperties

            https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#fixed-fields-13
         */

        private uint _multipleOf;
    }
}
