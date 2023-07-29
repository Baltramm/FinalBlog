using FinalBlog.App.ViewModels.Tags;
using FinalBlog.Data.DBModels.Tags;

namespace FinalBlog.App.Utils.Extensions
{
    public static class TagExtensions
    {
        public static Tag Convert(this Tag tag, TagEditViewModel model)
        {
            tag.Name = model.Name;
            return tag;
        } 
    }
}
