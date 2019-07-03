using System.Threading.Tasks;
using Abp.Application.Services;
using CAGLAR.Authorization.Accounts.Dto;

namespace CAGLAR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
