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
    public class AccountTransactionController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountTransaction/

        public ViewResult Index()
        {
            return View(context.AccountTransactions.Include(accounttransaction => accounttransaction.AccountStatement).Include(accounttransaction => accounttransaction.AccountTransactionType).ToList());
        }

        //
        // GET: /AccountTransaction/Details/5

        public ViewResult Details(int id)
        {
            AccountTransaction accounttransaction = context.AccountTransactions.Single(x => x.Id == id);
            return View(accounttransaction);
        }

        //
        // GET: /AccountTransaction/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAccountStatements = context.AccountStatements;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View();
        } 

        //
        // POST: /AccountTransaction/Create

        [HttpPost]
        public ActionResult Create(AccountTransaction accounttransaction)
        {
            if (ModelState.IsValid)
            {
                context.AccountTransactions.Add(accounttransaction);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAccountStatements = context.AccountStatements;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View(accounttransaction);
        }
        
        //
        // GET: /AccountTransaction/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountTransaction accounttransaction = context.AccountTransactions.Single(x => x.Id == id);
            ViewBag.PossibleAccountStatements = context.AccountStatements;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View(accounttransaction);
        }

        //
        // POST: /AccountTransaction/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountTransaction accounttransaction)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accounttransaction).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAccountStatements = context.AccountStatements;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View(accounttransaction);
        }

        //
        // GET: /AccountTransaction/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountTransaction accounttransaction = context.AccountTransactions.Single(x => x.Id == id);
            return View(accounttransaction);
        }

        //
        // POST: /AccountTransaction/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountTransaction accounttransaction = context.AccountTransactions.Single(x => x.Id == id);
            context.AccountTransactions.Remove(accounttransaction);
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