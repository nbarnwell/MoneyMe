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
    public class AccountStatementController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountStatement/

        public ViewResult Index()
        {
            return View(context.AccountStatements.Include(accountstatement => accountstatement.Account).Include(accountstatement => accountstatement.AccountTransactions).ToList());
        }

        //
        // GET: /AccountStatement/Details/5

        public ViewResult Details(int id)
        {
            AccountStatement accountstatement = context.AccountStatements.Single(x => x.Id == id);
            return View(accountstatement);
        }

        //
        // GET: /AccountStatement/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAccounts = context.Accounts;
            return View();
        } 

        //
        // POST: /AccountStatement/Create

        [HttpPost]
        public ActionResult Create(AccountStatement accountstatement)
        {
            if (ModelState.IsValid)
            {
                context.AccountStatements.Add(accountstatement);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAccounts = context.Accounts;
            return View(accountstatement);
        }
        
        //
        // GET: /AccountStatement/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountStatement accountstatement = context.AccountStatements.Single(x => x.Id == id);
            ViewBag.PossibleAccounts = context.Accounts;
            return View(accountstatement);
        }

        //
        // POST: /AccountStatement/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountStatement accountstatement)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accountstatement).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAccounts = context.Accounts;
            return View(accountstatement);
        }

        //
        // GET: /AccountStatement/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountStatement accountstatement = context.AccountStatements.Single(x => x.Id == id);
            return View(accountstatement);
        }

        //
        // POST: /AccountStatement/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountStatement accountstatement = context.AccountStatements.Single(x => x.Id == id);
            context.AccountStatements.Remove(accountstatement);
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