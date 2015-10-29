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
    public class AccountTransactionCategoryMatchPatternMatchMethodController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountTransactionCategoryMatchPatternMatchMethod/

        public ViewResult Index()
        {
            return View(context.AccountTransactionCategoryMatchPatternMatchMethods.Include(accounttransactioncategorymatchpatternmatchmethod => accounttransactioncategorymatchpatternmatchmethod.AccountTransactionCategoryMatchPatterns).ToList());
        }

        //
        // GET: /AccountTransactionCategoryMatchPatternMatchMethod/Details/5

        public ViewResult Details(int id)
        {
            AccountTransactionCategoryMatchPatternMatchMethod accounttransactioncategorymatchpatternmatchmethod = context.AccountTransactionCategoryMatchPatternMatchMethods.Single(x => x.Id == id);
            return View(accounttransactioncategorymatchpatternmatchmethod);
        }

        //
        // GET: /AccountTransactionCategoryMatchPatternMatchMethod/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AccountTransactionCategoryMatchPatternMatchMethod/Create

        [HttpPost]
        public ActionResult Create(AccountTransactionCategoryMatchPatternMatchMethod accounttransactioncategorymatchpatternmatchmethod)
        {
            if (ModelState.IsValid)
            {
                context.AccountTransactionCategoryMatchPatternMatchMethods.Add(accounttransactioncategorymatchpatternmatchmethod);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(accounttransactioncategorymatchpatternmatchmethod);
        }
        
        //
        // GET: /AccountTransactionCategoryMatchPatternMatchMethod/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountTransactionCategoryMatchPatternMatchMethod accounttransactioncategorymatchpatternmatchmethod = context.AccountTransactionCategoryMatchPatternMatchMethods.Single(x => x.Id == id);
            return View(accounttransactioncategorymatchpatternmatchmethod);
        }

        //
        // POST: /AccountTransactionCategoryMatchPatternMatchMethod/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountTransactionCategoryMatchPatternMatchMethod accounttransactioncategorymatchpatternmatchmethod)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accounttransactioncategorymatchpatternmatchmethod).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounttransactioncategorymatchpatternmatchmethod);
        }

        //
        // GET: /AccountTransactionCategoryMatchPatternMatchMethod/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountTransactionCategoryMatchPatternMatchMethod accounttransactioncategorymatchpatternmatchmethod = context.AccountTransactionCategoryMatchPatternMatchMethods.Single(x => x.Id == id);
            return View(accounttransactioncategorymatchpatternmatchmethod);
        }

        //
        // POST: /AccountTransactionCategoryMatchPatternMatchMethod/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountTransactionCategoryMatchPatternMatchMethod accounttransactioncategorymatchpatternmatchmethod = context.AccountTransactionCategoryMatchPatternMatchMethods.Single(x => x.Id == id);
            context.AccountTransactionCategoryMatchPatternMatchMethods.Remove(accounttransactioncategorymatchpatternmatchmethod);
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