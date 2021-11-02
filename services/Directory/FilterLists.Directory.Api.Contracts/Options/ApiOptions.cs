namespace FilterLists.Directory.Api.Contracts.Options
{
    internal class ApiOptions
    {
        public const string Key = "Api";

        public string DirectoryHost { get; init; } = null!;
    }
}
