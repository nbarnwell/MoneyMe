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
    public class AccountTransactionStatuController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AccountTransactionStatu/

        public ViewResult Index()
        {
            return View(context.AccountTransactionStatus.Include(accounttransactionstatu => accounttransactionstatu.AccountTransactions).ToList());
        }

        //
        // GET: /AccountTransactionStatu/Details/5

        public ViewResult Details(int id)
        {
            AccountTransactionStatu accounttransactionstatu = context.AccountTransactionStatus.Single(x => x.Id == id);
            return View(accounttransactionstatu);
        }

        //
        // GET: /AccountTransactionStatu/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AccountTransactionStatu/Create

        [HttpPost]
        public ActionResult Create(AccountTransactionStatu accounttransactionstatu)
        {
            if (ModelState.IsValid)
            {
                context.AccountTransactionStatus.Add(accounttransactionstatu);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(accounttransactionstatu);
        }
        
        //
        // GET: /AccountTransactionStatu/Edit/5
 
        public ActionResult Edit(int id)
        {
            AccountTransactionStatu accounttransactionstatu = context.AccountTransactionStatus.Single(x => x.Id == id);
            return View(accounttransactionstatu);
        }

        //
        // POST: /AccountTransactionStatu/Edit/5

        [HttpPost]
        public ActionResult Edit(AccountTransactionStatu accounttransactionstatu)
        {
            if (ModelState.IsValid)
            {
                context.Entry(accounttransactionstatu).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounttransactionstatu);
        }

        //
        // GET: /AccountTransactionStatu/Delete/5
 
        public ActionResult Delete(int id)
        {
            AccountTransactionStatu accounttransactionstatu = context.AccountTransactionStatus.Single(x => x.Id == id);
            return View(accounttransactionstatu);
        }

        //
        // POST: /AccountTransactionStatu/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountTransactionStatu accounttransactionstatu = context.AccountTransactionStatus.Single(x => x.Id == id);
            context.AccountTransactionStatus.Remove(accounttransactionstatu);
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