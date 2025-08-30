using System.ComponentModel.DataAnnotations;

namespace ContentHubAPI.Models.Domain
{
    public class PostDomainModel
    {
        [Key]
        public Guid PostId { get; set; }
        public string PostTitle { get; set; } = string.Empty;
        public string PostContent { get; set; } = string.Empty;
        public string? PostImageURL { get; set; } = string.Empty;
        public DateTime PostCreatedAt { get; set; } = DateTime.UtcNow;
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }


        // Navigation properties
        public UserDomainModel User { get; set; }
        public CategoryDomainModel Category { get; set; }
    }
}
