using System.Collections.Generic;
using kuchen.Roles.Dto;

namespace kuchen.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}