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
    public class AccountTransactionCategoryController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountTransactionCategory/

        public ViewResult Index()
        {
            return View(context.AccountTransactionCategories.Include(accounttransactioncategory => accounttransactioncategory.AccountTransactionCategoryMatchPatterns).ToList());
        }

        //
        // GET: /AccountTransactionCategory/Details/5

        public ViewResult Details(int id)
        {
            AccountTransactionCategory accounttransactioncategory = context.AccountTransactionCategories.Single(x => x.Id == id);
            return View(accounttransactioncategory);
        }

        //
        // GET: /AccountTransactionCategory/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AccountTransactionCategory/Create

        [HttpPost]
        public ActionResult Create(AccountTransactionCategory accounttransactioncategory)
        {
            if (ModelState.IsValid)
            {
                context.AccountTransactionCategories.Add(accounttransactioncategory);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(accounttransactioncategory);
        }
        
        //
        // GET: /AccountTransactionCategory/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountTransactionCategory accounttransactioncategory = context.AccountTransactionCategories.Single(x => x.Id == id);
            return View(accounttransactioncategory);
        }

        //
        // POST: /AccountTransactionCategory/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountTransactionCategory accounttransactioncategory)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accounttransactioncategory).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounttransactioncategory);
        }

        //
        // GET: /AccountTransactionCategory/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountTransactionCategory accounttransactioncategory = context.AccountTransactionCategories.Single(x => x.Id == id);
            return View(accounttransactioncategory);
        }

        //
        // POST: /AccountTransactionCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountTransactionCategory accounttransactioncategory = context.AccountTransactionCategories.Single(x => x.Id == id);
            context.AccountTransactionCategories.Remove(accounttransactioncategory);
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