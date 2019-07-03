using System.Collections.Generic;
using CAGLAR.Roles.Dto;
using CAGLAR.Users.Dto;

namespace CAGLAR.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}