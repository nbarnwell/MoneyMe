using System.Web.Mvc;

namespace MoneyMe.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}