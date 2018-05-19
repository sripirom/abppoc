using Microsoft.AspNetCore.Antiforgery;
using Bathawk.Controllers;

namespace Bathawk.Web.Host.Controllers
{
    public class AntiForgeryController : BathawkControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
