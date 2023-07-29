using Microsoft.AspNetCore.Mvc;
using FinalBlog.App.Controllers;
using FinalBlog.App.ViewModels.Comments;
using FinalBlog.Data.DBModels.Comments;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Users;
using FinalBlog.Data.Repositories;

namespace FinalBlog.App.Utils.Services.Interfaces
{
    public interface ICommentService
    {
        Task<IActionResult?> CheckDataAtCreateComment(CommentController controller);
        Task<bool> CreateComment(CommentCreateViewModel model);
        Task<CommentsViewModel> GetCommentsViewModel(int? postId, string? userId);
        Task<Comment?> GetCommentByIdAsync(int id);
        Task<CommentEditViewModel?> GetCommentEditViewModel(int id);
        Task<bool> UpdateComment(CommentEditViewModel model);
        Task<bool> DeleteComment(int id);
    }
}
