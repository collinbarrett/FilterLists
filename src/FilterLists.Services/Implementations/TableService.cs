using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class TableService : ITableService
    {
        private readonly IListRepository _listRepository;
        private readonly ITableCsvRepository _tableCsvRepository;

        public TableService(IListRepository listRepository, ITableCsvRepository tableCsvRepository)
        {
            _listRepository = listRepository;
            _tableCsvRepository = tableCsvRepository;
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
            var file = FetchFile(_tableCsvRepository.GetUrlByName(tableName), tableName).Result;
            //TODO: exec stored procedure to merge/upsert csv into corresponding db table
        }

        /// <summary>
        ///     fetch file as string from internet
        /// </summary>
        /// <param name="url">URL of file to fetch</param>
        /// <param name="fileName">name to save file as</param>
        /// <returns>string of file</returns>
        private static async Task<string> FetchFile(string url, string fileName)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "csv");
            Directory.CreateDirectory(path);
            var file = Path.Combine(path, fileName + ".csv");
            using (var fileStream = new FileStream(file, FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                await response.Content.CopyToAsync(fileStream);
            }
            return file;
        }
    }
}