using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CAGLAR.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CAGLARControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}