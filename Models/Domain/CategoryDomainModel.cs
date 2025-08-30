namespace ContentHubAPI.Models.Domain
{
    public class CategoryDomainModel
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription  { get; set; } = string.Empty;
    }
}
