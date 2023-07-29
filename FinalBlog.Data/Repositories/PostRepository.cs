using FinalBlog.Data;
using Microsoft.EntityFrameworkCore;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.Data.Repositories
{
    public class PostRepository : Repository<Post>
    {
        public PostRepository(FinalBlogContext context) : base(context) { }

        public async override Task<List<Post>> GetAllAsync() => 
            await Set.Include(p => p.Tags).Include(p => p.Comments).ToListAsync();

        public async override Task<Post?> GetAsync(int id) => 
            await Set.Include(p => p.Tags).Include(p => p.Comments).FirstOrDefaultAsync(p => p.Id == id);

        public async Task<List<Post>> GetPostsByUserIdAsync(int userId) =>
            await Set.Include(p => p.Tags).Include(p => p.Comments)
                .Where(p => p.UserId == userId).ToListAsync();
    }
}
