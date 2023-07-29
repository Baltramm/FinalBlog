using FinalBlog.Data.DBModels.Posts;

namespace FinalBlog.App.ViewModels.Posts
{
    public class PostsViewModel
    {
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
