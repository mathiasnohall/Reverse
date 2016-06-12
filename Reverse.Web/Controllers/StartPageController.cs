using Reverse.Web.ViewModels.Pages;
using System.Web.Mvc;

namespace Reverse.Web.Controllers
{
    public class StartPageController : Controller
    {
        public ActionResult Index()
        {
            var model = new PageViewModel();

            return View(model);
        }
    }
}