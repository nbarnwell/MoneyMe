using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MoneyMe.Web.Models.BankAccount;
using MoneyMe.Web.Models.Scaffolding;
using MoneyMe.Web.Services;

namespace MoneyMe.Web.Controllers
{
    public class BankAccountController : Controller
    {
        private readonly IScaffoldDbContext _context = new ScaffoldDbContext();

        [HttpGet]
        public ActionResult Details(int id)
        {
            var userId = Context.GetUserId();

            var query = _context.BankAccounts
                                .Where(x => x.Account.UserId == userId)
                                .Where(x => x.Id == id);

            var model = query.Select(
                x =>
                    new BankAccountWithStatementsViewModel
                    {
                        Id = x.Id,
                        Name = x.Account.Name,
                        CreditLimit = x.CreditLimit,
                        CurrentBalance = 0
                    }).FirstOrDefault();

            return View(model);
        }

        [HttpGet]
        [Route("BankAccount/{bankAccountId}/RecordPurchase")]
        public ActionResult RecordPurchase(int bankAccountId)
        {
            return View();
        }
    }
}