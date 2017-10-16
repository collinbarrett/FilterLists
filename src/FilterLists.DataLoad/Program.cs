using FilterLists.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.DataLoad
{
    //TODO: trigger on job or ideally via GitHub webhook when any .csv is updated in master
    public class Program
    {
        public static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            var tableService = serviceProvider.GetService<ITableService>();
            tableService.UpdateTables();
        }
    }
}