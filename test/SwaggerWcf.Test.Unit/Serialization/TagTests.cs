using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerWcf.Schema2;
using Xunit;

namespace SwaggerWcf.Test.Unit.Serialization
{
    public class TagTests
    {
        [Fact]
        public void Should_Deserialize_Tag()
        {
            const string jsonObject = @"
            {
              ""name"": ""pet"",
              ""description"": ""Everything about your Pets"",
              ""externalDocs"": {
                ""description"": ""Find out more"",
                ""url"": ""http://swagger.io""
              }
            }
            ";
            dynamic json = JsonConvert.DeserializeObject(jsonObject);
            Tag tag = JsonConvert.DeserializeObject<Tag>(jsonObject);

            Assert.Equal((string)json.name, tag.Name);
            Assert.Equal((string)json.description, tag.Description);
            Assert.NotNull(tag.ExternalDocs);
        }

        [Fact]
        public void Should_Serialize_Tag()
        {
            const string expectedJson = @"
            {
              ""name"": ""pet"",
              ""description"": ""Everything about your Pets"",
              ""externalDocs"": {
                ""description"": ""Find out more"",
                ""url"": ""http://swagger.io""
              }
            }
            ";

            Tag info = new Tag
            {
                Name = "pet",
                Description = "Everything about your Pets",
                ExternalDocs = new ExternalDocumentation
                {
                    Url = "http://swagger.io",
                    Description = "Find out more"
                }
            };

            string json = JsonConvert.SerializeObject(info);

            JObject expectedJObject = JObject.Parse(expectedJson);
            JObject actualJObject = JObject.Parse(json);
            Assert.True(JToken.DeepEquals(expectedJObject, actualJObject));
        }
    }
}
