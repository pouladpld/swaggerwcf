using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SwaggerWcf.Schema2
{
    /// <summary>
    /// Contact information for the exposed API.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Contact
    {
        /// <summary>
        /// The identifying name of the contact person/organization.
        /// </summary>
        public string Name;

        /// <summary>
        /// The email address of the contact person/organization. MUST be in the format of an email address.
        /// </summary>
        public string Email;

        /// <summary>
        /// The URL pointing to the contact information. MUST be in the format of a URL.
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
