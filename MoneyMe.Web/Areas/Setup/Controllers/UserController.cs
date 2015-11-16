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
    public class UserController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /User/

        public ViewResult Index()
        {
            return View(context.Users.Include(user => user.Family).Include(user => user.Accounts).ToList());
        }

        //
        // GET: /User/Details/5

        public ViewResult Details(int id)
        {
            User user = context.Users.Single(x => x.Id == id);
            return View(user);
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            ViewBag.PossibleAspNetUsers = context.AspNetUsers;
            ViewBag.PossibleFamilies = context.Families;
            return View();
        } 

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleAspNetUsers = context.AspNetUsers;
            ViewBag.PossibleFamilies = context.Families;
            return View(user);
        }
        
        //
        // GET: /User/Edit/5
 
        public ActionResult Edit(int id)
        {
            User user = context.Users.Single(x => x.Id == id);
            ViewBag.PossibleAspNetUsers = context.AspNetUsers;
            ViewBag.PossibleFamilies = context.Families;
            return View(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleAspNetUsers = context.AspNetUsers;
            ViewBag.PossibleFamilies = context.Families;
            return View(user);
        }

        //
        // GET: /User/Delete/5
 
        public ActionResult Delete(int id)
        {
            User user = context.Users.Single(x => x.Id == id);
            return View(user);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = context.Users.Single(x => x.Id == id);
            context.Users.Remove(user);
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