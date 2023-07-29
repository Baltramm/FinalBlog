using FinalBlog.Data.DBModels.Comments;

namespace FinalBlog.App.ViewModels.Comments
{
    public class CommentsViewModel
    {
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
