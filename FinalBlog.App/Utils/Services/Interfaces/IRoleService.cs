using FinalBlog.App.ViewModels.Users;
using FinalBlog.Data.DBModels.Roles;

namespace FinalBlog.App.Utils.Services.Interfaces
{
    public interface IRoleService
    {
        Task<List<Role>> GetRolesByUserAsync(int userId);
        Task<Role?> GetRoleByNameAsync(string roleName);
        Task<UserRolesViewModel?> GetUserRolesViewModelAsync(int id);
        Task<List<Role>> GetRolesFromModelAsync(UserRolesViewModel model);
    }
}
