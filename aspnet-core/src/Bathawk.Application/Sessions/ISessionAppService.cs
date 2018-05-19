using System.Threading.Tasks;
using Abp.Application.Services;
using Bathawk.Sessions.Dto;

namespace Bathawk.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
