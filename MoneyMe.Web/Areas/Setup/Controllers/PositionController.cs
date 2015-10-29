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
    public class PositionController : Controller
    {
        private ScaffoldDbContext context = new ScaffoldDbContext();

        //
        // GET: /Position/

        public ViewResult Index()
        {
            return View(context.Positions.Include(position => position.Accounts).Include(position => position.Users).Include(position => position.UserPositions).ToList());
        }

        //
        // GET: /Position/Details/5

        public ViewResult Details(int id)
        {
            Position position = context.Positions.Single(x => x.Id == id);
            return View(position);
        }

        //
        // GET: /Position/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Position/Create

        [HttpPost]
        public ActionResult Create(Position position)
        {
            if (ModelState.IsValid)
            {
                context.Positions.Add(position);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(position);
        }
        
        //
        // GET: /Position/Edit/5
 
        public ActionResult Edit(int id)
        {
            Position position = context.Positions.Single(x => x.Id == id);
            return View(position);
        }

        //
        // POST: /Position/Edit/5

        [HttpPost]
        public ActionResult Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                context.Entry(position).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(position);
        }

        //
        // GET: /Position/Delete/5
 
        public ActionResult Delete(int id)
        {
            Position position = context.Positions.Single(x => x.Id == id);
            return View(position);
        }

        //
        // POST: /Position/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Position position = context.Positions.Single(x => x.Id == id);
            context.Positions.Remove(position);
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