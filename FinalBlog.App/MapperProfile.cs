using AutoMapper;
using FinalBlog.App.ViewModels.Comments;
using FinalBlog.App.ViewModels.Posts;
using FinalBlog.App.ViewModels.Tags;
using FinalBlog.App.ViewModels.Users;
using FinalBlog.Data.DBModels.Comments;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Tags;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.App
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserRegisterViewModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(m => m.Login))
                .ForMember(u => u.Email, opt => opt.MapFrom(m => m.EmailReg))
                .ForMember(u => u.PasswordHash, opt => opt.MapFrom(m => m.PasswordReg.GetHashCode()));

            CreateMap<User, UserEditViewModel>()
                .ForMember(u => u.Login, opt => opt.MapFrom(m => m.UserName));

            CreateMap<PostCreateViewModel, Post>();

            CreateMap<Post, PostEditViewModel>()
                .ForMember(m => m.PostTags, opt => opt.MapFrom(p => string.Join(" ", p.Tags.Select(p => p.Name))));

            CreateMap<CommentCreateViewModel, Comment>();

            CreateMap<Comment, CommentEditViewModel>();

            CreateMap<TagCreateViewModel, Tag>();

            CreateMap<Tag, TagEditViewModel>();
        }
    }
}
