using System.ComponentModel.DataAnnotations;

namespace ContentHubAPI.Models.Domain
{
    public class UserDomainModel
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPasswordHash { get; set; } = string.Empty;

    }
}
