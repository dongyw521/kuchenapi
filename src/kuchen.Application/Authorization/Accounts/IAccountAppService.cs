using System.Threading.Tasks;
using Abp.Application.Services;
using kuchen.Authorization.Accounts.Dto;

namespace kuchen.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
