using System.ComponentModel.DataAnnotations;

namespace FinalBlog.App.ViewModels.Users
{
    public class UserRolesViewModel
    {
        public int UserId { get; init; }

        [Display(Name = "Пользователь")]
        public bool IsUser { get; set; }

        [Display(Name = "Админ")]
        public bool IsAdmin { get; set; }

    }
}
