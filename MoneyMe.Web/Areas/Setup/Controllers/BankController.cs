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
    public class BankController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /Bank/

        public ViewResult Index()
        {
            return View(context.Banks.Include(bank => bank.BankSpecificTransactionTypes).ToList());
        }

        //
        // GET: /Bank/Details/5

        public ViewResult Details(int id)
        {
            Bank bank = context.Banks.Single(x => x.Id == id);
            return View(bank);
        }

        //
        // GET: /Bank/Create

        public ActionResult Create()
        {
            ViewBag.PossiblePositions = context.Positions;
            return View();
        } 

        //
        // POST: /Bank/Create

        [HttpPost]
        public ActionResult Create(Bank bank)
        {
            if (ModelState.IsValid)
            {
                context.Banks.Add(bank);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossiblePositions = context.Positions;
            return View(bank);
        }
        
        //
        // GET: /Bank/Edit/5
 
        public ActionResult Edit(int id)
        {
            Bank bank = context.Banks.Single(x => x.Id == id);
            ViewBag.PossiblePositions = context.Positions;
            return View(bank);
        }

        //
        // POST: /Bank/Edit/5

        [HttpPost]
        public ActionResult Edit(Bank bank)
        {
            if (ModelState.IsValid)
            {
                context.Entry(bank).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossiblePositions = context.Positions;
            return View(bank);
        }

        //
        // GET: /Bank/Delete/5
 
        public ActionResult Delete(int id)
        {
            Bank bank = context.Banks.Single(x => x.Id == id);
            return View(bank);
        }

        //
        // POST: /Bank/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Bank bank = context.Banks.Single(x => x.Id == id);
            context.Banks.Remove(bank);
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