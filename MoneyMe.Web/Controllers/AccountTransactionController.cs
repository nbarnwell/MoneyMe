using System;
using System.Linq;
using System.Web.Mvc;
using Dapper;
using MoneyMe.Web.Models.AccountTransactionHandling;
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

        [HttpPost]
        public ActionResult Create(CreateAccountTransactionViewModel data)
        {
            var row = new
            {
                ReceiptDate                = data.ReceiptDate,
                RecordedDate               = DateTimeOffset.UtcNow,
                AccountTransactionStatusId = 1, // Recorded
                Amount                     = data.Amount,
                Payee                      = data.Payee,
                Description                = data.Description,
                AccountTransactionTypeId   = data.AccountTransactionTypeId
            };

            var transactionId =
                DataService.Execute(
                    c => c.ExecuteScalar<int>(
                        @"insert into AccountTransaction (
                        ReceiptDate,
                        RecordedDate,
                        AccountTransactionStatusId,
                        Amount,
                        Description,
                        AccountTransactionTypeId
                    ) values (
                        @ReceiptDate,
                        @RecordedDate,
                        @AccountTransactionStatusId,
                        @Amount,
                        @Description,
                        @AccountTransactionTypeId
                    );
                    select scope_identity();",
                        row));

            return RedirectToAction("SetCategories", new { transactionId, description = data.Description });
        }

        [HttpGet]
        public ActionResult SetCategories(int transactionId, string description)
        {
            var categories = DataService.GetCategories();
            var categoryList = categories.Select(x => new CategoryViewModel { Id = x.Id, Name = x.Name }).ToList();
            var suggestedCategories = CategoryService.SuggestCategories(categories, description);
            var suggestedCategoryList = suggestedCategories.Select(x => new CategoryViewModel { Id = x.Id, Name = x.Name }).ToList();

            ViewBag.Categories = categoryList;
            ViewBag.SuggestedCategories = suggestedCategoryList;

            var vm = new SetCategoriesViewModel
            {
                TransactionId = transactionId,
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult SetCategories(SetCategoriesViewModel data)
        {
            return null;
        }
    }
}