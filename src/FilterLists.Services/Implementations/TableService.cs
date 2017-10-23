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

        public void UpdateTables()
        {
            UpdateListTable();
        }

        public void UpdateListTable()
        {
            var localCsvFilePath = FetchFile(_tableCsvRepository.GetUrlByName("List"), "List").Result;
            TextReader textReader = File.OpenText(localCsvFilePath);
            var csv = new CsvReader(textReader);
            csv.Configuration.MissingFieldFound = null;
            var records = csv.GetRecords<List>();
            //TODO: delete file when finished
        }

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