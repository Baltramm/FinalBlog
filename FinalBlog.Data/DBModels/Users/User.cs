using Microsoft.AspNetCore.Identity;
using FinalBlog.Data.DBModels.Comments;
using FinalBlog.Data.DBModels.Posts;
using FinalBlog.Data.DBModels.Roles;

namespace FinalBlog.Data.DBModels.Users
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }

        public List<Role> Roles { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }

        public User()
        {
            Photo = "https://cdn.xxl.thumbs.canstockphoto.ru/%D0%B3%D0%BB%D1%83%D0%BF%D1%8B%D0%B9-%D1%81%D1%82%D0%BE%D0%BA%D0%BE%D0%B2%D0%BE%D0%B5-%D1%84%D0%BE%D1%82%D0%BE_csp2060104.jpg";            
        }
    }
}
