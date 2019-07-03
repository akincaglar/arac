using System.Threading.Tasks;
using Abp.Application.Services;
using CAGLAR.Configuration.Dto;

namespace CAGLAR.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}