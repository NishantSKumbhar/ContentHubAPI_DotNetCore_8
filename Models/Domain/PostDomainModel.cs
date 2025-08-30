namespace ContentHubAPI.Models.Domain
{
    public class PostDomainModel
    {
        public Guid PostID { get; set; }
        public string PostTitle { get; set; } = string.Empty;
        public string PostContent { get; set; } = string.Empty;
        public string? PostImageURL { get; set; } = string.Empty;
        public DateTime PostCreatedAt { get; set; } = DateTime.UtcNow;
        public Guid UserID { get; set; }
        public Guid CategoryID { get; set; }


        // Navigation properties
        public UserDomainModel User { get; set; }
        public CategoryDomainModel Category { get; set; }
    }
}
