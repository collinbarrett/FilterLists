using FilterLists.Services.Contracts;
using FilterLists.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.DataLoad
{
    //TODO: trigger on job or ideally via GitHub webhook when any .csv is updated
    internal class DataLoad
    {
        private static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ITableService, TableService>()
                .BuildServiceProvider();
            serviceProvider.GetService<ITableService>().UpdateTables();
        }
    }
}