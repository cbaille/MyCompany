using Microsoft.AspNetCore.Antiforgery;
using MyCompany.Controllers;

namespace MyCompany.Web.Host.Controllers
{
    public class AntiForgeryController : MyCompanyControllerBase
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
