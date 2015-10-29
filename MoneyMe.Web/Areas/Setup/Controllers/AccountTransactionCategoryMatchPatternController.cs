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
    public class AccountTransactionCategoryMatchPatternController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountTransactionCategoryMatchPattern/

        public ViewResult Index()
        {
            return View(context.AccountTransactionCategoryMatchPatterns.Include(accounttransactioncategorymatchpattern => accounttransactioncategorymatchpattern.AccountTransactionCategory).ToList());
        }

        //
        // GET: /AccountTransactionCategoryMatchPattern/Details/5

        public ViewResult Details(int id)
        {
            AccountTransactionCategoryMatchPattern accounttransactioncategorymatchpattern = context.AccountTransactionCategoryMatchPatterns.Single(x => x.Id == id);
            return View(accounttransactioncategorymatchpattern);
        }

        //
        // GET: /AccountTransactionCategoryMatchPattern/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAccountTransactionCategories = context.AccountTransactionCategories;
            return View();
        } 

        //
        // POST: /AccountTransactionCategoryMatchPattern/Create

        [HttpPost]
        public ActionResult Create(AccountTransactionCategoryMatchPattern accounttransactioncategorymatchpattern)
        {
            if (ModelState.IsValid)
            {
                context.AccountTransactionCategoryMatchPatterns.Add(accounttransactioncategorymatchpattern);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAccountTransactionCategories = context.AccountTransactionCategories;
            return View(accounttransactioncategorymatchpattern);
        }
        
        //
        // GET: /AccountTransactionCategoryMatchPattern/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountTransactionCategoryMatchPattern accounttransactioncategorymatchpattern = context.AccountTransactionCategoryMatchPatterns.Single(x => x.Id == id);
            ViewBag.PossibleAccountTransactionCategories = context.AccountTransactionCategories;
            return View(accounttransactioncategorymatchpattern);
        }

        //
        // POST: /AccountTransactionCategoryMatchPattern/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountTransactionCategoryMatchPattern accounttransactioncategorymatchpattern)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accounttransactioncategorymatchpattern).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAccountTransactionCategories = context.AccountTransactionCategories;
            return View(accounttransactioncategorymatchpattern);
        }

        //
        // GET: /AccountTransactionCategoryMatchPattern/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountTransactionCategoryMatchPattern accounttransactioncategorymatchpattern = context.AccountTransactionCategoryMatchPatterns.Single(x => x.Id == id);
            return View(accounttransactioncategorymatchpattern);
        }

        //
        // POST: /AccountTransactionCategoryMatchPattern/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountTransactionCategoryMatchPattern accounttransactioncategorymatchpattern = context.AccountTransactionCategoryMatchPatterns.Single(x => x.Id == id);
            context.AccountTransactionCategoryMatchPatterns.Remove(accounttransactioncategorymatchpattern);
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