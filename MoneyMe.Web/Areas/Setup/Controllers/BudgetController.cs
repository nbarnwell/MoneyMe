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
    public class BudgetController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /Budget/

        public ViewResult Index()
        {
            return View(context.Budgets.Include(budget => budget.Account).ToList());
        }

        //
        // GET: /Budget/Details/5

        public ViewResult Details(int id)
        {
            Budget budget = context.Budgets.Single(x => x.Id == id);
            return View(budget);
        }

        //
        // GET: /Budget/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAccounts = context.Accounts;
            return View();
        } 

        //
        // POST: /Budget/Create

        [HttpPost]
        public ActionResult Create(Budget budget)
        {
            if (ModelState.IsValid)
            {
                context.Budgets.Add(budget);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAccounts = context.Accounts;
            return View(budget);
        }
        
        //
        // GET: /Budget/Edit/5
 
        public ActionResult Edit(int id)
        {
            Budget budget = context.Budgets.Single(x => x.Id == id);
            ViewBag.PossibleAccounts = context.Accounts;
            return View(budget);
        }

        //
        // POST: /Budget/Edit/5

        [HttpPost]
        public ActionResult Edit(Budget budget)
        {
            if (ModelState.IsValid)
            {
                context.Entry(budget).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAccounts = context.Accounts;
            return View(budget);
        }

        //
        // GET: /Budget/Delete/5
 
        public ActionResult Delete(int id)
        {
            Budget budget = context.Budgets.Single(x => x.Id == id);
            return View(budget);
        }

        //
        // POST: /Budget/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Budget budget = context.Budgets.Single(x => x.Id == id);
            context.Budgets.Remove(budget);
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