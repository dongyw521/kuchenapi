using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using kuchen.Roles.Dto;
using kuchen.Users.Dto;

namespace kuchen.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
