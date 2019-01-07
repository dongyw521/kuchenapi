using Abp.Authorization;
using kuchen.Authorization.Roles;
using kuchen.Authorization.Users;

namespace kuchen.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
