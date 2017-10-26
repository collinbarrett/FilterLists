namespace FilterLists.Data.Models.Contracts
{
    public interface ILanguage
    {
        string Iso6391 { get; set; }
        string Iso6392 { get; set; }
        string Iso6392B { get; set; }
        string Iso6392T { get; set; }
        string Iso6393 { get; set; }
        string LocalName { get; set; }
        string Name { get; set; }
    }
}