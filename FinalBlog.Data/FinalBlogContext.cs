using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalBlog.Data.DBModels.Comments;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Roles;
using FinalBlog.Data.DBModels.Tags;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.Data
{
    public class FinalBlogContext : IdentityDbContext<User, Role, int>
    {
        public FinalBlogContext(DbContextOptions<FinalBlogContext> contextOptions) : base(contextOptions) =>
            Database.Migrate();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new СommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
