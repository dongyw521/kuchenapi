using Abp.Application.Services;
using Abp.Application.Services.Dto;
using kuchen.MultiTenancy.Dto;

namespace kuchen.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

