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
    public class FundController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /Fund/

        public ViewResult Index()
        {
            return View(context.Funds.Include(fund => fund.Account).ToList());
        }

        //
        // GET: /Fund/Details/5

        public ViewResult Details(int id)
        {
            Fund fund = context.Funds.Single(x => x.Id == id);
            return View(fund);
        }

        //
        // GET: /Fund/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAccounts = context.Accounts;
            return View();
        } 

        //
        // POST: /Fund/Create

        [HttpPost]
        public ActionResult Create(Fund fund)
        {
            if (ModelState.IsValid)
            {
                context.Funds.Add(fund);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAccounts = context.Accounts;
            return View(fund);
        }
        
        //
        // GET: /Fund/Edit/5
 
        public ActionResult Edit(int id)
        {
            Fund fund = context.Funds.Single(x => x.Id == id);
            ViewBag.PossibleAccounts = context.Accounts;
            return View(fund);
        }

        //
        // POST: /Fund/Edit/5

        [HttpPost]
        public ActionResult Edit(Fund fund)
        {
            if (ModelState.IsValid)
            {
                context.Entry(fund).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAccounts = context.Accounts;
            return View(fund);
        }

        //
        // GET: /Fund/Delete/5
 
        public ActionResult Delete(int id)
        {
            Fund fund = context.Funds.Single(x => x.Id == id);
            return View(fund);
        }

        //
        // POST: /Fund/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Fund fund = context.Funds.Single(x => x.Id == id);
            context.Funds.Remove(fund);
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