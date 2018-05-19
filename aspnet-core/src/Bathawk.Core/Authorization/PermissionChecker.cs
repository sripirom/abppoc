using Abp.Authorization;
using Bathawk.Authorization.Roles;
using Bathawk.Authorization.Users;

namespace Bathawk.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
