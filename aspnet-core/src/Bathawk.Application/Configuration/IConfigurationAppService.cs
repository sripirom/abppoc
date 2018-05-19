using System.Threading.Tasks;
using Bathawk.Configuration.Dto;

namespace Bathawk.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
