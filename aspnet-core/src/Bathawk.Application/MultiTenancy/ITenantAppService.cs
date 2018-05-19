using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bathawk.MultiTenancy.Dto;

namespace Bathawk.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
