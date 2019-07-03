using System.Threading.Tasks;
using Abp.Application.Services;
using CAGLAR.Sessions.Dto;

namespace CAGLAR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
