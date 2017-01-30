using Abp.Authorization;
using ZSC.PhoneBook.Authorization.Roles;
using ZSC.PhoneBook.MultiTenancy;
using ZSC.PhoneBook.Users;

namespace ZSC.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
