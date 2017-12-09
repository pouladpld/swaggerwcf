using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerWcf.Schema2;
using Xunit;

namespace SwaggerWcf.Test.Unit.Serialization
{
    public class ExternalDocumentationTests
    {
        [Fact]
        public void Should_Deserialize_ExternalDocumentation()
        {
            const string jsonObject = @"
            {
              ""description"": ""Find out more"",
              ""url"": ""http://swagger.io""
            }
            ";
            dynamic json = JsonConvert.DeserializeObject(jsonObject);
            ExternalDocumentation externalDoc = JsonConvert.DeserializeObject<ExternalDocumentation>(jsonObject);

            Assert.Equal((string)json.url, externalDoc.Url);
            Assert.Equal((string)json.description, externalDoc.Description);
        }

        [Fact]
        public void Should_Serialize_ExternalDocumentation()
        {
            const string expectedJson = @"
            {
              ""description"": ""Find out more"",
              ""url"": ""http://swagger.io""
            }
            ";

            ExternalDocumentation externalDoc = new ExternalDocumentation
            {
                Url = "http://swagger.io",
                Description = "Find out more"
            };

            string json = JsonConvert.SerializeObject(externalDoc);

            JObject expectedJObject = JObject.Parse(expectedJson);
            JObject actualJObject = JObject.Parse(json);
            Assert.True(JToken.DeepEquals(expectedJObject, actualJObject));
        }
    }
}
