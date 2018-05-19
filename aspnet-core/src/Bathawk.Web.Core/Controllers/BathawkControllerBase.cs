using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Bathawk.Controllers
{
    public abstract class BathawkControllerBase: AbpController
    {
        protected BathawkControllerBase()
        {
            LocalizationSourceName = BathawkConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
