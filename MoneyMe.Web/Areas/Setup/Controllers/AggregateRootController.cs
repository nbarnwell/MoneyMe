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
    public class AggregateRootController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AggregateRoot/

        public ViewResult Index()
        {
            return View(context.AggregateRoots.Include(aggregateroot => aggregateroot.AggregateRootEvents).ToList());
        }

        //
        // GET: /AggregateRoot/Details/5

        public ViewResult Details(System.Guid id)
        {
            AggregateRoot aggregateroot = context.AggregateRoots.Single(x => x.Id == id);
            return View(aggregateroot);
        }

        //
        // GET: /AggregateRoot/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AggregateRoot/Create

        [HttpPost]
        public ActionResult Create(AggregateRoot aggregateroot)
        {
            if (ModelState.IsValid)
            {
                aggregateroot.Id = Guid.NewGuid();
                context.AggregateRoots.Add(aggregateroot);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aggregateroot);
        }
        
        //
        // GET: /AggregateRoot/Edit/5
 
        public ActionResult Edit(System.Guid id)
        {
            AggregateRoot aggregateroot = context.AggregateRoots.Single(x => x.Id == id);
            return View(aggregateroot);
        }

        //
        // POST: /AggregateRoot/Edit/5

        [HttpPost]
        public ActionResult Edit(AggregateRoot aggregateroot)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aggregateroot).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aggregateroot);
        }

        //
        // GET: /AggregateRoot/Delete/5
 
        public ActionResult Delete(System.Guid id)
        {
            AggregateRoot aggregateroot = context.AggregateRoots.Single(x => x.Id == id);
            return View(aggregateroot);
        }

        //
        // POST: /AggregateRoot/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(System.Guid id)
        {
            AggregateRoot aggregateroot = context.AggregateRoots.Single(x => x.Id == id);
            context.AggregateRoots.Remove(aggregateroot);
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