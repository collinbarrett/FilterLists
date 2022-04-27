namespace FilterLists.Api.Persistence;

public static class TableStorageConstants
{
    public const string ConnectionStringConfigKey = "FilterListsStappApiStorage";
    public const string FilterListsTableName = "filterlists";
    public const string FilterListsPartitionKey = " ";
    public const string LanguagesTableName = "languages";
    public const string LanguagesPartitionKey = " ";
    public const string LicensesTableName = "licenses";
    public const string LicensesPartitionKey = " ";
    public const string MaintainersTableName = "maintainers";
    public const string MaintainersPartitionKey = " ";
    public const string SoftwareTableName = "software";
    public const string SoftwarePartitionKey = " ";
    public const string SyntaxesTableName = "syntaxes";
    public const string SyntaxesPartitionKey = " ";
    public const string TagsTableName = "tags";
    public const string TagsPartitionKey = " ";
}