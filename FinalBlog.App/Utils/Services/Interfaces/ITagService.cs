using FinalBlog.App.Controllers;
using FinalBlog.App.ViewModels.Tags;
using FinalBlog.App.ViewModels.Tags.Interfaces;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Tags;
using FinalBlog.Data.Repositories;

namespace FinalBlog.App.Utils.Services.Interfaces
{
    public interface ITagService
    {
        Task<TagsViewModel?> GetTagsViewModelAsync(int? tagId, string? postId);
        Task<Tag?> GetTagByIdAsync(int id);
        Task<Tag?> CheckTagNameAsync<T>(TagController controller, T model) where T : ITagViewModel;
        Task CreateTagAsync(TagCreateViewModel model);
        Task<List<Tag>?> CreateTagForPostAsync(string? postTags);
        Task<TagEditViewModel?> GetTagEditViewModelAsync(int id);
        Task<bool> UpdateTagAsync(TagEditViewModel model);
        Task<bool> DeleteTagAsync(int id);
    }
}
