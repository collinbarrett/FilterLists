namespace FilterLists.Data.Models.Contracts
{
    public interface IMaintainer
    {
        string Email { get; set; }
        string HomeUrl { get; set; }
        string Name { get; set; }
        string TwitterHandle { get; set; }
    }
}