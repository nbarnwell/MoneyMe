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
    public class FamilyController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /Family/

        public ViewResult Index()
        {
            return View(context.Families.Include(family => family.AccountTransactionCategories).Include(family => family.Users).ToList());
        }

        //
        // GET: /Family/Details/5

        public ViewResult Details(int id)
        {
            Family family = context.Families.Single(x => x.Id == id);
            return View(family);
        }

        //
        // GET: /Family/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Family/Create

        [HttpPost]
        public ActionResult Create(Family family)
        {
            if (ModelState.IsValid)
            {
                context.Families.Add(family);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(family);
        }
        
        //
        // GET: /Family/Edit/5
 
        public ActionResult Edit(int id)
        {
            Family family = context.Families.Single(x => x.Id == id);
            return View(family);
        }

        //
        // POST: /Family/Edit/5

        [HttpPost]
        public ActionResult Edit(Family family)
        {
            if (ModelState.IsValid)
            {
                context.Entry(family).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(family);
        }

        //
        // GET: /Family/Delete/5
 
        public ActionResult Delete(int id)
        {
            Family family = context.Families.Single(x => x.Id == id);
            return View(family);
        }

        //
        // POST: /Family/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Family family = context.Families.Single(x => x.Id == id);
            context.Families.Remove(family);
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