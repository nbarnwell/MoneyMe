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
    public class BankAccountController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /BankAccount/

        public ViewResult Index()
        {
            return View(context.BankAccounts.Include(bankaccount => bankaccount.Bank).Include(bankaccount => bankaccount.Account).ToList());
        }

        //
        // GET: /BankAccount/Details/5

        public ViewResult Details(int id)
        {
            BankAccount bankaccount = context.BankAccounts.Single(x => x.Id == id);
            return View(bankaccount);
        }

        //
        // GET: /BankAccount/Create

        public ActionResult Create()
        {
            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccounts = context.Accounts;
            return View();
        } 

        //
        // POST: /BankAccount/Create

        [HttpPost]
        public ActionResult Create(BankAccount bankaccount)
        {
            if (ModelState.IsValid)
            {
                context.BankAccounts.Add(bankaccount);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccounts = context.Accounts;
            return View(bankaccount);
        }
        
        //
        // GET: /BankAccount/Edit/5
 
        public ActionResult Edit(int id)
        {
            BankAccount bankaccount = context.BankAccounts.Single(x => x.Id == id);
            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccounts = context.Accounts;
            return View(bankaccount);
        }

        //
        // POST: /BankAccount/Edit/5

        [HttpPost]
        public ActionResult Edit(BankAccount bankaccount)
        {
            if (ModelState.IsValid)
            {
                context.Entry(bankaccount).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccounts = context.Accounts;
            return View(bankaccount);
        }

        //
        // GET: /BankAccount/Delete/5
 
        public ActionResult Delete(int id)
        {
            BankAccount bankaccount = context.BankAccounts.Single(x => x.Id == id);
            return View(bankaccount);
        }

        //
        // POST: /BankAccount/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BankAccount bankaccount = context.BankAccounts.Single(x => x.Id == id);
            context.BankAccounts.Remove(bankaccount);
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