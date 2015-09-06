using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using Dapper;
using FileHelpers;
using MoneyMe.Web.Services;

namespace MoneyMe.Web.Controllers
{
    public class ImportController : Controller
    {
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);

                var engine = new FileHelperEngine<HalifaxTransaction>();
                var csv = engine.ReadFile(path);

                using (var transaction = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString))
                {
                    int count = 0;
                    foreach (var txn in csv)
                    {
                        var accountId = DataService.GetAccountId(txn.AccountNumber, txn.SortCode);

                        connection.Execute(
                            @"insert into ");

                        count++;
                    }

                    transaction.Complete();

                    return View(string.Format("Stored {0} transactions", count));
                }
            }

            return View();
        }
    }

    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class HalifaxTransaction
    {
        [FieldConverter(ConverterKind.Date, "dd/MM/yyyy")]
        public DateTime TransactionDate;
        public string TransactionType;
        public string SortCode;
        public string AccountNumber;
        public string TransactionDescription;
        public decimal DebitAmount;
        public decimal CreditAmount;
        public decimal Balance;
    }
}