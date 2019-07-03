using Abp.Authorization;
using CAGLAR.Authorization.Roles;
using CAGLAR.Authorization.Users;

namespace CAGLAR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
