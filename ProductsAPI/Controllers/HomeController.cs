using System.Web.Mvc;

namespace ProductsAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("https://github.com/jeremyolu");
        }
    }
}
