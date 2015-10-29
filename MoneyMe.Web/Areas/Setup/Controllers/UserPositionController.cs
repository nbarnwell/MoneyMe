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
    public class UserPositionController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /UserPosition/

        public ViewResult Index()
        {
            return View(context.UserPositions.Include(userposition => userposition.User).Include(userposition => userposition.Position).ToList());
        }

        //
        // GET: /UserPosition/Details/5

        public ViewResult Details(int id)
        {
            UserPosition userposition = context.UserPositions.Single(x => x.Id == id);
            return View(userposition);
        }

        //
        // GET: /UserPosition/Create

        public ActionResult Create()
        {
            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossiblePositions = context.Positions;
            return View();
        } 

        //
        // POST: /UserPosition/Create

        [HttpPost]
        public ActionResult Create(UserPosition userposition)
        {
            if (ModelState.IsValid)
            {
                context.UserPositions.Add(userposition);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossiblePositions = context.Positions;
            return View(userposition);
        }
        
        //
        // GET: /UserPosition/Edit/5
 
        public ActionResult Edit(int id)
        {
            UserPosition userposition = context.UserPositions.Single(x => x.Id == id);
            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossiblePositions = context.Positions;
            return View(userposition);
        }

        //
        // POST: /UserPosition/Edit/5

        [HttpPost]
        public ActionResult Edit(UserPosition userposition)
        {
            if (ModelState.IsValid)
            {
                context.Entry(userposition).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossiblePositions = context.Positions;
            return View(userposition);
        }

        //
        // GET: /UserPosition/Delete/5
 
        public ActionResult Delete(int id)
        {
            UserPosition userposition = context.UserPositions.Single(x => x.Id == id);
            return View(userposition);
        }

        //
        // POST: /UserPosition/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UserPosition userposition = context.UserPositions.Single(x => x.Id == id);
            context.UserPositions.Remove(userposition);
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