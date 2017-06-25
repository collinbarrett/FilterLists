using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FilterLists.Data.Models;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class TableService : ITableService
    {
        private readonly IListRepository _listRepository;

        public TableService(IListRepository listRepository)
        {
            _listRepository = listRepository;
        }

        /// <summary>
        ///     update all tables via .CSVs from GitHub
        /// </summary>
        public void UpdateTables()
        {
            //TODO: loop through all CSVs
            UpdateTable("List");
        }

        /// <summary>
        ///     update table via .CSV from GitHub
        /// </summary>
        /// <param name="tableName">name of database table</param>
        public void UpdateTable(string tableName)
        {
            //TODO: fetch CSV URL from db table
            const string csvUrl = "https://raw.githubusercontent.com/collinbarrett/FilterLists/dataToCsv/data/List.csv";
            var file = FetchFile(csvUrl).Result;
            var csvRows = file.Split('\n');
            var headerCells = csvRows[0].Split(',');
            for (var i = 1; i < csvRows.Length; i++)
                if (!string.IsNullOrEmpty(csvRows[i]))
                {
                    var cells = csvRows[i].Split(',');
                    var list = new List
                    {
                        Name = cells[0]
                        //TODO: finish mappings, try to make generic for any table type using headerCells as properties
                    };
                }
            //TODO: update table via repo/EF
        }

        /// <summary>
        ///     fetch a file as a string from the internet
        /// </summary>
        /// <param name="url">URL of file to fetch</param>
        /// <returns>string of file</returns>
        private static async Task<string> FetchFile(string url)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("FilterLists", "1.0"));
            return await httpClient.GetStringAsync(url);
        }
    }
}