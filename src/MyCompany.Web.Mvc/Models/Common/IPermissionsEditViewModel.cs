using System.Collections.Generic;
using MyCompany.Roles.Dto;

namespace MyCompany.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}