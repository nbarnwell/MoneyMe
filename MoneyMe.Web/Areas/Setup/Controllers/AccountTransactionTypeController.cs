using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyMe.Web.Models.Scaffolding;

namespace MoneyMe.Web.Areas.Setup.Controllers
{   
    public class AccountTransactionTypeController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountTransactionType/

        public ViewResult Index()
        {
            return View(context.AccountTransactionTypes.Include(accounttransactiontype => accounttransactiontype.AccountTransactions).Include(accounttransactiontype => accounttransactiontype.BankSpecificTransactionTypes).ToList());
        }

        //
        // GET: /AccountTransactionType/Details/5

        public ViewResult Details(int id)
        {
            AccountTransactionType accounttransactiontype = context.AccountTransactionTypes.Single(x => x.Id == id);
            return View(accounttransactiontype);
        }

        //
        // GET: /AccountTransactionType/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AccountTransactionType/Create

        [HttpPost]
        public ActionResult Create(AccountTransactionType accounttransactiontype)
        {
            if (ModelState.IsValid)
            {
                context.AccountTransactionTypes.Add(accounttransactiontype);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(accounttransactiontype);
        }
        
        //
        // GET: /AccountTransactionType/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountTransactionType accounttransactiontype = context.AccountTransactionTypes.Single(x => x.Id == id);
            return View(accounttransactiontype);
        }

        //
        // POST: /AccountTransactionType/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountTransactionType accounttransactiontype)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accounttransactiontype).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounttransactiontype);
        }

        //
        // GET: /AccountTransactionType/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountTransactionType accounttransactiontype = context.AccountTransactionTypes.Single(x => x.Id == id);
            return View(accounttransactiontype);
        }

        //
        // POST: /AccountTransactionType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountTransactionType accounttransactiontype = context.AccountTransactionTypes.Single(x => x.Id == id);
            context.AccountTransactionTypes.Remove(accounttransactiontype);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}