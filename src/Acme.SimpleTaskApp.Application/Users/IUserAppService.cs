using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Acme.SimpleTaskApp.Roles.Dto;
using Acme.SimpleTaskApp.Users.Dto;

namespace Acme.SimpleTaskApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
