using System.Threading.Tasks;
using Abp.Application.Services;
using kuchen.Sessions.Dto;

namespace kuchen.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
