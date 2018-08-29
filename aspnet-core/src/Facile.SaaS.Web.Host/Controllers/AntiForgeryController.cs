using Microsoft.AspNetCore.Antiforgery;
using Facile.SaaS.Controllers;

namespace Facile.SaaS.Web.Host.Controllers
{
    public class AntiForgeryController : SaaSControllerBase
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
