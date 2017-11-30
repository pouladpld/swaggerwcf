using System;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SwaggerWcf.Builder
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            await Task.CompletedTask;


            var dll = Assembly.LoadFile(args[0]);
            var allPublicTypes = dll.GetExportedTypes();
            var serviceContractTypes = allPublicTypes
                .Select(t => new
                {
                    Type = t,
                    IsServiceContract = !(t.GetCustomAttribute<ServiceContractAttribute>() is null)
                })
                .Where(typeInfo => typeInfo.IsServiceContract)
                .Select(typeInfo => typeInfo.Type)
                .ToArray()
                ;
        }
    }
}
