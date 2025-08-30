namespace ContentHubAPI.Models.Domain
{
    public class UserDomainModel
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPasswordHash { get; set; } = string.Empty;

    }
}
