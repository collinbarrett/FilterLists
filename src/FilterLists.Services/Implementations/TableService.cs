using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using CsvHelper;
using FilterLists.Data.Models.Implementations;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class TableService : ITableService
    {
        private readonly ITableCsvRepository _tableCsvRepository;

        public TableService(ITableCsvRepository tableCsvRepository)
        {
            _tableCsvRepository = tableCsvRepository;
        }

        /// <summary>
        ///     update all tables via .CSVs from GitHub
        /// </summary>
        public void UpdateTables()
        {
            UpdateListTable();
        }

        /// <summary>
        ///     update table via List.csv from GitHub
        /// </summary>
        public void UpdateListTable()
        {
            var localCsvFilePath = FetchFile(_tableCsvRepository.GetUrlByName("List"), "List").Result;
            TextReader textReader = File.OpenText(localCsvFilePath);
            var csv = new CsvReader(textReader);
            csv.Configuration.MissingFieldFound = null;
            var records = csv.GetRecords<List>();
            //TODO: delete file when finished
        }

        /// <summary>
        ///     fetch file as string from internet
        /// </summary>
        /// <param name="url">URL of file to fetch</param>
        /// <param name="fileName">name to save file as</param>
        /// <returns>string of file</returns>
        private static async Task<string> FetchFile(string url, string fileName)
        {
            var response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "csv");
            Directory.CreateDirectory(path);
            var file = Path.Combine(path, fileName + ".csv");
            using (var fileStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await response.Content.CopyToAsync(fileStream);
            }
            return file;
        }
    }
}