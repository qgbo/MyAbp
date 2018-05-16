using Microsoft.AspNetCore.Antiforgery;
using Acme.SimpleTaskApp.Controllers;

namespace Acme.SimpleTaskApp.Web.Host.Controllers
{
    public class AntiForgeryController : SimpleTaskAppControllerBase
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
