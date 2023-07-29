using FinalBlog.App.ViewModels.Posts;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Tags;
using System.Text.RegularExpressions;

namespace FinalBlog.App.Utils.Extensions
{
    public static class PostExtensions
    {
        public static Post Convert(this Post post, PostEditViewModel model)
        {
            post.Title = model.Title;
            post.Content = model.Content;

            return post;
        }
    }
}
