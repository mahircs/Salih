using System.Web.Mvc;

namespace Salih.Web.Controllers
{
    public class HomeController : SalihControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}