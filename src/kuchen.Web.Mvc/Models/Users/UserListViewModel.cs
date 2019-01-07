using System.Collections.Generic;
using kuchen.Roles.Dto;
using kuchen.Users.Dto;

namespace kuchen.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
