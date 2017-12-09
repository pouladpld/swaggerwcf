using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerWcf.Schema2;
using Xunit;

namespace SwaggerWcf.Test.Unit.Serialization
{
    public class InfoTests
    {
        [Fact]
        public void Should_Deserialize_Info()
        {
            const string jsonObject = @"
            {
              ""title"": ""Swagger Sample App"",
              ""description"": ""This is a sample server Petstore server."",
              ""termsOfService"": ""http://swagger.io/terms/"",
              ""contact"": {
                ""name"": ""API Support"",
                ""url"": ""http://www.swagger.io/support"",
                ""email"": ""support@swagger.io""
              },
              ""license"": {
                ""name"": ""Apache 2.0"",
                ""url"": ""http://www.apache.org/licenses/LICENSE-2.0.html""
              },
              ""version"": ""1.0.1""
            }
            ";
            dynamic json = JsonConvert.DeserializeObject(jsonObject);
            Info info = JsonConvert.DeserializeObject<Info>(jsonObject);

            Assert.Equal((string)json.title, info.Title);
            Assert.Equal((string)json.version, info.Version);
            Assert.Equal((string)json.description, info.Description);
            Assert.Equal((string)json.termsOfService, info.TermsOfService);
            Assert.Equal((string)json.description, info.Description);
            Assert.NotNull(info.License);
            Assert.NotNull(info.Contact);
        }

        [Fact]
        public void Should_Serialize_Info()
        {
            const string expectedJson = @"
            {
              ""title"": ""Swagger Sample App"",
              ""version"": ""1.0.1"",
              ""description"": ""This is a sample server Petstore server."",
              ""termsOfService"": ""http://swagger.io/terms/"",
              ""license"": {
                ""name"": ""Apache 2.0"",
                ""url"": ""http://www.apache.org/licenses/LICENSE-2.0.html""
              },
              ""contact"": {
                ""name"": ""API Support"",
                ""email"": ""support@swagger.io"",
                ""url"": ""http://www.swagger.io/support""
              }
            }";

            Info info = new Info
            {
                Title = "Swagger Sample App",
                Description = "This is a sample server Petstore server.",
                TermsOfService = "http://swagger.io/terms/",
                Version = "1.0.1",
                Contact = new Contact
                {
                    Name = "API Support",
                    Url = "http://www.swagger.io/support",
                    Email = "support@swagger.io"
                },
                License = new License
                {
                    Name = "Apache 2.0",
                    Url = "http://www.apache.org/licenses/LICENSE-2.0.html"
                }
            };

            string json = JsonConvert.SerializeObject(info);

            JObject expectedJObject = JObject.Parse(expectedJson);
            JObject actualJObject = JObject.Parse(json);
            Assert.True(JToken.DeepEquals(expectedJObject, actualJObject));
        }

        [Fact]
        public void Should_Deserialize_License()
        {
            const string jsonObject = @"
            {
              ""name"": ""Apache 2.0"",
              ""url"": ""http://www.apache.org/licenses/LICENSE-2.0.html""
            }
            ";
            dynamic json = JsonConvert.DeserializeObject(jsonObject);
            License license = JsonConvert.DeserializeObject<License>(jsonObject);

            Assert.Equal((string)json.name, license.Name);
            Assert.Equal((string)json.url, license.Url);
        }

        [Fact]
        public void Should_Serialize_License()
        {
            const string expectedJson = @"
            {
              ""name"": ""Apache 2.0"",
              ""url"": ""http://www.apache.org/licenses/LICENSE-2.0.html""
            }";

            License license = new License
            {
                Name = "Apache 2.0",
                Url = "http://www.apache.org/licenses/LICENSE-2.0.html"
            };

            string json = JsonConvert.SerializeObject(license);

            JObject expectedJObject = JObject.Parse(expectedJson);
            JObject actualJObject = JObject.Parse(json);
            Assert.True(JToken.DeepEquals(expectedJObject, actualJObject));
        }

        [Fact]
        public void Should_Deserialize_Contact()
        {
            const string jsonObject = @"
            {
              ""name"": ""API Support"",
              ""url"": ""http://www.swagger.io/support"",
              ""email"": ""support@swagger.io""
            }";

            dynamic json = JsonConvert.DeserializeObject(jsonObject);
            Contact contact = JsonConvert.DeserializeObject<Contact>(jsonObject);

            Assert.Equal((string)json.name, contact.Name);
            Assert.Equal((string)json.url, contact.Url);
            Assert.Equal((string)json.email, contact.Email);
        }

        [Fact]
        public void Should_Serialize_Contact()
        {
            const string expectedJson = @"
            {
              ""name"": ""API Support"",
              ""url"": ""http://www.swagger.io/support"",
              ""email"": ""support@swagger.io""
            }";

            Contact license = new Contact
            {
                Name = "API Support",
                Url = "http://www.swagger.io/support",
                Email = "support@swagger.io"
            };

            string json = JsonConvert.SerializeObject(license);

            JObject expectedJObject = JObject.Parse(expectedJson);
            JObject actualJObject = JObject.Parse(json);
            Assert.True(JToken.DeepEquals(expectedJObject, actualJObject));
        }
    }
}
