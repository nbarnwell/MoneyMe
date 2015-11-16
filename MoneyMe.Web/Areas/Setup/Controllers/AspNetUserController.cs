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
    public class AspNetUserController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AspNetUser/

        public ViewResult Index()
        {
            return View(context.AspNetUsers.Include(aspnetuser => aspnetuser.AspNetRoles).Include(aspnetuser => aspnetuser.AspNetUserClaims).ToList());
        }

        //
        // GET: /AspNetUser/Details/5

        public ViewResult Details(string id)
        {
            AspNetUser aspnetuser = context.AspNetUsers.Single(x => x.Id == id);
            return View(aspnetuser);
        }

        //
        // GET: /AspNetUser/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AspNetUser/Create

        [HttpPost]
        public ActionResult Create(AspNetUser aspnetuser)
        {
            if (ModelState.IsValid)
            {
                context.AspNetUsers.Add(aspnetuser);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aspnetuser);
        }
        
        //
        // GET: /AspNetUser/Edit/5
 
        public ActionResult Edit(string id)
        {
            AspNetUser aspnetuser = context.AspNetUsers.Single(x => x.Id == id);
            return View(aspnetuser);
        }

        //
        // POST: /AspNetUser/Edit/5

        [HttpPost]
        public ActionResult Edit(AspNetUser aspnetuser)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aspnetuser).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aspnetuser);
        }

        //
        // GET: /AspNetUser/Delete/5
 
        public ActionResult Delete(string id)
        {
            AspNetUser aspnetuser = context.AspNetUsers.Single(x => x.Id == id);
            return View(aspnetuser);
        }

        //
        // POST: /AspNetUser/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            AspNetUser aspnetuser = context.AspNetUsers.Single(x => x.Id == id);
            context.AspNetUsers.Remove(aspnetuser);
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