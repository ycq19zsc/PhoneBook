using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZSC.PhoneBook.Users.Dto;

namespace ZSC.PhoneBook.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}