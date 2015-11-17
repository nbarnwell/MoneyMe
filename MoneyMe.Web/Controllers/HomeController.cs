using System.Linq;
using System.Web.Mvc;
using MoneyMe.Web.Models.Scaffolding;
using MoneyMe.Web.Services;

namespace MoneyMe.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScaffoldDbContext _context = new ScaffoldDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            int userId = Context.GetUserId();
            var accounts = _context.Accounts
                                   .Where(x => x.UserId == userId)
                                   .ToList();
            ViewBag.Accounts = accounts;
            return View();
        }
    }
}