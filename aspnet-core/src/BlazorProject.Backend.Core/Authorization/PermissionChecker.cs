using Abp.Authorization;
using BlazorProject.Backend.Authorization.Roles;
using BlazorProject.Backend.Authorization.Users;

namespace BlazorProject.Backend.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
