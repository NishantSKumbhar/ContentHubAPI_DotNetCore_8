using System.ComponentModel.DataAnnotations;

namespace ContentHubAPI.Models.Domain
{
    public class CategoryDomainModel
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription  { get; set; } = string.Empty;
    }
}
