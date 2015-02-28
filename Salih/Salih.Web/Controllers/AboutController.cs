using System.Web.Mvc;

namespace Salih.Web.Controllers
{
    public class AboutController : SalihControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}