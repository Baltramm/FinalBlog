using Microsoft.AspNetCore.Identity;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.Data.DBModels.Roles
{
    public class Role : IdentityRole<int>
    {
        public List<User> Users { get; set; }

        public Role(string name) : base(name) 
        {
            NormalizedName = name.ToUpper();
        }
    }
}
