using System.Collections.Generic;
using Acme.SimpleTaskApp.Roles.Dto;
using Acme.SimpleTaskApp.Users.Dto;

namespace Acme.SimpleTaskApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
