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
    public class AspnetPersonalizationPerUserController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AspnetPersonalizationPerUser/

        public ViewResult Index()
        {
            return View(context.AspnetPersonalizationPerUsers.ToList());
        }

        //
        // GET: /AspnetPersonalizationPerUser/Details/5

        public ViewResult Details(System.Guid id)
        {
            AspnetPersonalizationPerUser aspnetpersonalizationperuser = context.AspnetPersonalizationPerUsers.Single(x => x.Id == id);
            return View(aspnetpersonalizationperuser);
        }

        //
        // GET: /AspnetPersonalizationPerUser/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUsers = context.Users;
            return View();
        } 

        //
        // POST: /AspnetPersonalizationPerUser/Create

        [HttpPost]
        public ActionResult Create(AspnetPersonalizationPerUser aspnetpersonalizationperuser)
        {
            if (ModelState.IsValid)
            {
                aspnetpersonalizationperuser.Id = Guid.NewGuid();
                context.AspnetPersonalizationPerUsers.Add(aspnetpersonalizationperuser);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUsers = context.Users;
            return View(aspnetpersonalizationperuser);
        }
        
        //
        // GET: /AspnetPersonalizationPerUser/Edit/5
 
        public ActionResult Edit(System.Guid id)
        {
            AspnetPersonalizationPerUser aspnetpersonalizationperuser = context.AspnetPersonalizationPerUsers.Single(x => x.Id == id);
            ViewBag.PossibleUsers = context.Users;
            return View(aspnetpersonalizationperuser);
        }

        //
        // POST: /AspnetPersonalizationPerUser/Edit/5

        [HttpPost]
        public ActionResult Edit(AspnetPersonalizationPerUser aspnetpersonalizationperuser)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aspnetpersonalizationperuser).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUsers = context.Users;
            return View(aspnetpersonalizationperuser);
        }

        //
        // GET: /AspnetPersonalizationPerUser/Delete/5
 
        public ActionResult Delete(System.Guid id)
        {
            AspnetPersonalizationPerUser aspnetpersonalizationperuser = context.AspnetPersonalizationPerUsers.Single(x => x.Id == id);
            return View(aspnetpersonalizationperuser);
        }

        //
        // POST: /AspnetPersonalizationPerUser/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(System.Guid id)
        {
            AspnetPersonalizationPerUser aspnetpersonalizationperuser = context.AspnetPersonalizationPerUsers.Single(x => x.Id == id);
            context.AspnetPersonalizationPerUsers.Remove(aspnetpersonalizationperuser);
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