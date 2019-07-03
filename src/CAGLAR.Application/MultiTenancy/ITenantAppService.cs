using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CAGLAR.MultiTenancy.Dto;

namespace CAGLAR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
