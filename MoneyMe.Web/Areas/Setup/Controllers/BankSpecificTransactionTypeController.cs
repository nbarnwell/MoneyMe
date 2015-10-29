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
    public class BankSpecificTransactionTypeController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /BankSpecificTransactionType/

        public ViewResult Index()
        {
            return View(context.BankSpecificTransactionTypes.Include(bankspecifictransactiontype => bankspecifictransactiontype.Bank).Include(bankspecifictransactiontype => bankspecifictransactiontype.AccountTransactionType).ToList());
        }

        //
        // GET: /BankSpecificTransactionType/Details/5

        public ViewResult Details(int id)
        {
            BankSpecificTransactionType bankspecifictransactiontype = context.BankSpecificTransactionTypes.Single(x => x.Id == id);
            return View(bankspecifictransactiontype);
        }

        //
        // GET: /BankSpecificTransactionType/Create

        public ActionResult Create()
        {
            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View();
        } 

        //
        // POST: /BankSpecificTransactionType/Create

        [HttpPost]
        public ActionResult Create(BankSpecificTransactionType bankspecifictransactiontype)
        {
            if (ModelState.IsValid)
            {
                context.BankSpecificTransactionTypes.Add(bankspecifictransactiontype);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View(bankspecifictransactiontype);
        }
        
        //
        // GET: /BankSpecificTransactionType/Edit/5
 
        public ActionResult Edit(int id)
        {
            BankSpecificTransactionType bankspecifictransactiontype = context.BankSpecificTransactionTypes.Single(x => x.Id == id);
            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View(bankspecifictransactiontype);
        }

        //
        // POST: /BankSpecificTransactionType/Edit/5

        [HttpPost]
        public ActionResult Edit(BankSpecificTransactionType bankspecifictransactiontype)
        {
            if (ModelState.IsValid)
            {
                context.Entry(bankspecifictransactiontype).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleBanks = context.Banks;
            ViewBag.PossibleAccountTransactionTypes = context.AccountTransactionTypes;
            return View(bankspecifictransactiontype);
        }

        //
        // GET: /BankSpecificTransactionType/Delete/5
 
        public ActionResult Delete(int id)
        {
            BankSpecificTransactionType bankspecifictransactiontype = context.BankSpecificTransactionTypes.Single(x => x.Id == id);
            return View(bankspecifictransactiontype);
        }

        //
        // POST: /BankSpecificTransactionType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BankSpecificTransactionType bankspecifictransactiontype = context.BankSpecificTransactionTypes.Single(x => x.Id == id);
            context.BankSpecificTransactionTypes.Remove(bankspecifictransactiontype);
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