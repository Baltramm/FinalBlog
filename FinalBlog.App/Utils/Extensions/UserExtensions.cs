using FinalBlog.App.ViewModels.Users;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.App.Utils.Extensions
{
    public static class UserExtensions
    {
        public static User Convert(this User user, UserEditViewModel model)
        {
            user.FirstName = model.FirstName;
            user.SecondName = model.SecondName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.UserName = model.Login;
            user.BirthDate = model.BirthDate;
            user.Photo = model.Photo;

            return user;
        } 
    }
}
