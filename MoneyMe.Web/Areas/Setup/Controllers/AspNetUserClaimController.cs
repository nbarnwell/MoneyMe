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
    public class AspNetUserClaimController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /AspNetUserClaim/

        public ViewResult Index()
        {
            return View(context.AspNetUserClaims.ToList());
        }

        //
        // GET: /AspNetUserClaim/Details/5

        public ViewResult Details(int id)
        {
            AspNetUserClaim aspnetuserclaim = context.AspNetUserClaims.Single(x => x.Id == id);
            return View(aspnetuserclaim);
        }

        //
        // GET: /AspNetUserClaim/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUsers = context.Users;
            return View();
        } 

        //
        // POST: /AspNetUserClaim/Create

        [HttpPost]
        public ActionResult Create(AspNetUserClaim aspnetuserclaim)
        {
            if (ModelState.IsValid)
            {
                context.AspNetUserClaims.Add(aspnetuserclaim);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUsers = context.Users;
            return View(aspnetuserclaim);
        }
        
        //
        // GET: /AspNetUserClaim/Edit/5
 
        public ActionResult Edit(int id)
        {
            AspNetUserClaim aspnetuserclaim = context.AspNetUserClaims.Single(x => x.Id == id);
            ViewBag.PossibleUsers = context.Users;
            return View(aspnetuserclaim);
        }

        //
        // POST: /AspNetUserClaim/Edit/5

        [HttpPost]
        public ActionResult Edit(AspNetUserClaim aspnetuserclaim)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aspnetuserclaim).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUsers = context.Users;
            return View(aspnetuserclaim);
        }

        //
        // GET: /AspNetUserClaim/Delete/5
 
        public ActionResult Delete(int id)
        {
            AspNetUserClaim aspnetuserclaim = context.AspNetUserClaims.Single(x => x.Id == id);
            return View(aspnetuserclaim);
        }

        //
        // POST: /AspNetUserClaim/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AspNetUserClaim aspnetuserclaim = context.AspNetUserClaims.Single(x => x.Id == id);
            context.AspNetUserClaims.Remove(aspnetuserclaim);
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