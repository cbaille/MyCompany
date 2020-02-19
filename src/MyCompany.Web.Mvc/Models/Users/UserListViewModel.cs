using System.Collections.Generic;
using MyCompany.Roles.Dto;
using MyCompany.Users.Dto;

namespace MyCompany.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
