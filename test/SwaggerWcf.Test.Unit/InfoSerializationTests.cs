using System;
using Newtonsoft.Json;
using SwaggerWcf.Schema2;
using Xunit;

namespace SwaggerWcf.Test.Unit
{
    public class InfoSerializationTests
    {
        [Fact]
        public void Should_Deserialize_Info()
        {
            string jsonObject = @"
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
            // ToDo assert contact
            // ToDo assert license
        }
    }
}
