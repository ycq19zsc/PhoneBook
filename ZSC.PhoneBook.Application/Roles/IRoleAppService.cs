using System.Threading.Tasks;
using Abp.Application.Services;
using ZSC.PhoneBook.Roles.Dto;

namespace ZSC.PhoneBook.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
