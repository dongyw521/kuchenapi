using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using kuchen.Controllers;

namespace kuchen.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : kuchenControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
