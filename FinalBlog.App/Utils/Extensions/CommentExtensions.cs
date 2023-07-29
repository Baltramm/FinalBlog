using FinalBlog.App.ViewModels.Comments;
using FinalBlog.Data.DBModels.Comments;

namespace FinalBlog.App.Utils.Extensions
{
    public static class CommentExtensions
    {
        public static Comment Convert(this Comment comment, CommentEditViewModel model)
        {
            comment.Text = model.Text;
            comment.UserId = model.UserId;
            return comment;
        }
    }
}
