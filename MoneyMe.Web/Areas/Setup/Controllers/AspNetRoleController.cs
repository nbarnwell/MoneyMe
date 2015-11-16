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
    public class AspNetRoleController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AspNetRole/

        public ViewResult Index()
        {
            return View(context.AspNetRoles.Include(aspnetrole => aspnetrole.AspNetUsers).ToList());
        }

        //
        // GET: /AspNetRole/Details/5

        public ViewResult Details(string id)
        {
            AspNetRole aspnetrole = context.AspNetRoles.Single(x => x.Id == id);
            return View(aspnetrole);
        }

        //
        // GET: /AspNetRole/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AspNetRole/Create

        [HttpPost]
        public ActionResult Create(AspNetRole aspnetrole)
        {
            if (ModelState.IsValid)
            {
                context.AspNetRoles.Add(aspnetrole);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aspnetrole);
        }
        
        //
        // GET: /AspNetRole/Edit/5
 
        public ActionResult Edit(string id)
        {
            AspNetRole aspnetrole = context.AspNetRoles.Single(x => x.Id == id);
            return View(aspnetrole);
        }

        //
        // POST: /AspNetRole/Edit/5

        [HttpPost]
        public ActionResult Edit(AspNetRole aspnetrole)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aspnetrole).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aspnetrole);
        }

        //
        // GET: /AspNetRole/Delete/5
 
        public ActionResult Delete(string id)
        {
            AspNetRole aspnetrole = context.AspNetRoles.Single(x => x.Id == id);
            return View(aspnetrole);
        }

        //
        // POST: /AspNetRole/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            AspNetRole aspnetrole = context.AspNetRoles.Single(x => x.Id == id);
            context.AspNetRoles.Remove(aspnetrole);
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