using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Acme.SimpleTaskApp.MultiTenancy.Dto;

namespace Acme.SimpleTaskApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
