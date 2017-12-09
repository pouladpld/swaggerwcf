using System.IO;
using Newtonsoft.Json;
using SwaggerWcf.Schema2;
using Xunit;

namespace SwaggerWcf.Test.Unit.Serialization
{
    public class SwaggerSchemaTests
    {
        [Fact]
        public void Should_Deserialize_Schema_PetStore()
        {
            string jsonObject = File.ReadAllText("Files/swagger-petstore.json");

            dynamic json = JsonConvert.DeserializeObject(jsonObject);
            SwaggerSchema schema = JsonConvert.DeserializeObject<SwaggerSchema>(jsonObject);

            Assert.Equal(schema.Swagger, (string)json.swagger);
            Assert.Equal(schema.Host, (string)json.host);
            Assert.Equal(schema.BasePath, (string)json.basePath);
            Assert.NotNull(schema.Info);
            Assert.NotEmpty(schema.Schemes);
            Assert.NotEmpty(schema.Paths);
            Assert.NotNull(schema.Definitions);
            Assert.NotNull(schema.Tags);
            //Assert.NotNull(schema.SecurityDefinitions); ToDo
            Assert.NotNull(schema.ExternalDocs);
        }
    }
}
