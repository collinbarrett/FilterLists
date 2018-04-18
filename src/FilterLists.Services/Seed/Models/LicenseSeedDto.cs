namespace FilterLists.Services.Seed.Models
{
    public class LicenseSeedDto
    {
        public int Id { get; set; }
        public string DescriptionUrl { get; set; }
        public string Name { get; set; }
        public bool PermissiveAdaptation { get; set; }
        public bool PermissiveCommercial { get; set; }
    }
}