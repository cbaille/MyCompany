using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyCompany.Controllers;

namespace MyCompany.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyCompanyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
