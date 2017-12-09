namespace SwaggerWcf.Schema2.Constants
{
    /// <summary>
    /// Primitives have an optional modifier property format. Swagger uses several known formats to more finely define the data type being used. However, the format property is an open string-valued property, and can have any value to support documentation needs.
    /// </summary>
    public static class TypeFormats
    {
        public const string Int32 = "int32";

        public const string Int64 = "int64";

        public const string Float = "float";

        public const string Double = "double";

        public const string Byte = "byte";

        public const string Binary = "binary";

        public const string Date = "date";

        public const string DateTime = "date-time";

        public const string Password = "password";
    }
}