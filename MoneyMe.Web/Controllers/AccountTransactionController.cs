using System.Collections.Generic;
using System.Web.Mvc;
using MoneyMe.Web.Models;
using MoneyMe.Web.Services;

namespace MoneyMe.Web.Controllers
{
    public class AccountTransactionController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Accounts = DataService.GetAccounts();
            ViewBag.PaymentMethods = DataService.GetAccountTransactionTypes();
            return View();
        }
    }
}