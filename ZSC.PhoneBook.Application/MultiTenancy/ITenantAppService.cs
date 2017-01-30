using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZSC.PhoneBook.MultiTenancy.Dto;

namespace ZSC.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
