using System.Threading.Tasks;
using kuchen.Configuration.Dto;

namespace kuchen.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
