using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerWcf.Schema2;
using Xunit;

namespace SwaggerWcf.Test.Unit.Serialization
{
    public class SchemeTests
    {
        [Fact]
        public void Should_Deserialize_Scheme()
        {
            const string jsonValue = @"""https""";
            Scheme scheme = JsonConvert.DeserializeObject<Scheme>(jsonValue);
            Assert.Equal(Scheme.Https, scheme);
        }

        [Fact]
        public void Should_Deserialize_Schemes_Array()
        {
            const string jsonArray = @"
            [
              ""http"", ""https"", ""ws"", ""wss""
            ]";
            Scheme[] schemes = JsonConvert.DeserializeObject<Scheme[]>(jsonArray);

            Assert.Equal(Scheme.Http, schemes[0]);
            Assert.Equal(Scheme.Https, schemes[1]);
            Assert.Equal(Scheme.Ws, schemes[2]);
            Assert.Equal(Scheme.Wss, schemes[3]);
        }

        [Fact]
        public void Should_Serialize_Schemes_Array()
        {
            const string expectedJsonArray = @"
            [
              ""ws"", ""http"", ""wss"", ""https""
            ]";

            Scheme[] schemes = new[]
            {
                Scheme.Ws,
                Scheme.Http,
                Scheme.Wss,
                Scheme.Https,
            };

            string jsonArray = JsonConvert.SerializeObject(schemes);

            JArray expectedJObject = JArray.Parse(expectedJsonArray);
            JArray actualJObject = JArray.Parse(jsonArray);
            Assert.True(JToken.DeepEquals(expectedJObject, actualJObject));
        }
    }
}
