using System.Threading.Tasks;
using Abp.Application.Services;
using Bathawk.Authorization.Accounts.Dto;

namespace Bathawk.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
