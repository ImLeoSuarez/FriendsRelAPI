using Microsoft.Extensions.Hosting;
using friendsrelapi.Services;
using friendsrelapi.Schema;
using Microsoft.Extensions.DependencyInjection;

namespace friendsrelapi
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(s=>{
                    s.AddTransient<ICharacterRepository, CharacterRepository>();
                    s.AddSingleton<ExecutorProxy>();
                    s.AddGraphQLServer().AddQueryType<Query>().AddFiltering().AddSorting();
                })
                .Build();

            host.Run();
        }
    }
}