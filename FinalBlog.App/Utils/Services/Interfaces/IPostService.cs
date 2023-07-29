using FinalBlog.App.Controllers;
using FinalBlog.App.ViewModels.Posts;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Tags;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.App.Utils.Services.Interfaces
{
    public interface IPostService
    {
        Task<bool> CreatePost(PostCreateViewModel model, List<Tag>? tags);
        Task<PostsViewModel> GetPostViewModel(int? postId, string? userId);
        Task<PostEditViewModel?> GetPostEditViewModel(int id, string? userId);
        Task<bool> DeletePost(int id);
        Task<Post?> GetPostByIdAsync(int id);
        Task<bool> UpdatePostAsync(PostEditViewModel model);
    }
}
