namespace FilterLists.Data.Models.Contracts
{
    public interface IMaintainer
    {
        string Name { get; set; }
        string Email { get; set; }
        string TwitterHandle { get; set; }
        string HomeUrl { get; set; }
    }
}