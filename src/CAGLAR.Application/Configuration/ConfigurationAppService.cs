using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CAGLAR.Configuration.Dto;

namespace CAGLAR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CAGLARAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
