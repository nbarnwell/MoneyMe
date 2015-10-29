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
    public class AggregateRootEventController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AggregateRootEvent/

        public ViewResult Index()
        {
            return View(context.AggregateRootEvents.ToList());
        }

        //
        // GET: /AggregateRootEvent/Details/5

        public ViewResult Details(System.Guid id)
        {
            AggregateRootEvent aggregaterootevent = context.AggregateRootEvents.Single(x => x.Id == id);
            return View(aggregaterootevent);
        }

        //
        // GET: /AggregateRootEvent/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AggregateRootEvent/Create

        [HttpPost]
        public ActionResult Create(AggregateRootEvent aggregaterootevent)
        {
            if (ModelState.IsValid)
            {
                aggregaterootevent.Id = Guid.NewGuid();
                context.AggregateRootEvents.Add(aggregaterootevent);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aggregaterootevent);
        }
        
        //
        // GET: /AggregateRootEvent/Edit/5
 
        public ActionResult Edit(System.Guid id)
        {
            AggregateRootEvent aggregaterootevent = context.AggregateRootEvents.Single(x => x.Id == id);
            return View(aggregaterootevent);
        }

        //
        // POST: /AggregateRootEvent/Edit/5

        [HttpPost]
        public ActionResult Edit(AggregateRootEvent aggregaterootevent)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aggregaterootevent).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aggregaterootevent);
        }

        //
        // GET: /AggregateRootEvent/Delete/5
 
        public ActionResult Delete(System.Guid id)
        {
            AggregateRootEvent aggregaterootevent = context.AggregateRootEvents.Single(x => x.Id == id);
            return View(aggregaterootevent);
        }

        //
        // POST: /AggregateRootEvent/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(System.Guid id)
        {
            AggregateRootEvent aggregaterootevent = context.AggregateRootEvents.Single(x => x.Id == id);
            context.AggregateRootEvents.Remove(aggregaterootevent);
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