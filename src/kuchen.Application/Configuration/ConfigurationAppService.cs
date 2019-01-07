using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using kuchen.Configuration.Dto;

namespace kuchen.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : kuchenAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
