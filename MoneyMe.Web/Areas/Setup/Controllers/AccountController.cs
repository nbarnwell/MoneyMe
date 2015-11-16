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
    public class AccountController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /Account/

        public ViewResult Index()
        {
            return View(context.Accounts.Include(account => account.User).Include(account => account.AccountStatements).Include(account => account.BankAccounts).Include(account => account.Funds).ToList());
        }

        //
        // GET: /Account/Details/5

        public ViewResult Details(int id)
        {
            Account account = context.Accounts.Single(x => x.Id == id);
            return View(account);
        }

        //
        // GET: /Account/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUsers = context.Users.ToList();
            return View();
        } 

        //
        // POST: /Account/Create

        [HttpPost]
        public ActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                context.Accounts.Add(account);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUsers = context.Users;
            return View(account);
        }
        
        //
        // GET: /Account/Edit/5
 
        public ActionResult Edit(int id)
        {
            Account account = context.Accounts.Single(x => x.Id == id);
            ViewBag.PossibleUsers = context.Users;
            return View(account);
        }

        //
        // POST: /Account/Edit/5

        [HttpPost]
        public ActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                context.Entry(account).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUsers = context.Users;
            return View(account);
        }

        //
        // GET: /Account/Delete/5
 
        public ActionResult Delete(int id)
        {
            Account account = context.Accounts.Single(x => x.Id == id);
            return View(account);
        }

        //
        // POST: /Account/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Account account = context.Accounts.Single(x => x.Id == id);
            context.Accounts.Remove(account);
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