using ContentHubAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContentHubAPI.Data
{
    public class ContentHubAPIDbContext: DbContext
    {
        public ContentHubAPIDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }

        //when we run entity framework commands, it will create tables for these models
        public DbSet<CategoryDomainModel> Categories { get; set; }
        public DbSet<UserDomainModel> Users { get; set; }
        public DbSet<PostDomainModel> Posts { get; set; }
    }
}
