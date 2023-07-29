using Microsoft.AspNetCore.Identity;
using FinalBlog.App.Controllers;
using FinalBlog.App.ViewModels.Users;
using FinalBlog.Data.DBModels.Users;
using System.Security.Claims;

namespace FinalBlog.App.Utils.Services.Interfaces
{
    public interface IUserService
    {
        Task<(IdentityResult, User)> CreateUserAsync(UserRegisterViewModel model);
        Task<IdentityResult> UpdateUserAsync(UserEditViewModel model, User user);
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<List<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int id);
        Task<User?> GetUserByEmailAsync(string email);
        Task<User?> GetUserByNameAsync(string name);
        Task<bool> DeleteByIdAsync(int id);
        Task<List<Claim>> GetClaims(User user);
        Task<UserEditViewModel?> GetUserEditViewModelAsync(int id);
        Task<UsersViewModel?> GetUsersViewModelAsync(int? id);
        Task CheckDataAtRegistration(UserController controller, UserRegisterViewModel model);
        Task<User?> CheckDataAtEdition(UserController controller, UserEditViewModel model);
    }
}
