using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Places.Models;
using Places.DAL;

namespace Places.Controllers
{
    public class CountyController : Controller
    {
        private PlaceContext db = new PlaceContext();

        //
        // GET: /County/

        public ActionResult Index()
        {
            return View(db.Countys.ToList());
        }

        //
        // GET: /County/Details/5

        public ActionResult Details(int id = 0)
        {
            County county = db.Countys.Find(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        //
        // GET: /County/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /County/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(County county)
        {
            if (ModelState.IsValid)
            {
                db.Countys.Add(county);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(county);
        }

        //
        // GET: /County/Edit/5

        public ActionResult Edit(int id = 0)
        {
            County county = db.Countys.Find(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        //
        // POST: /County/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(County county)
        {
            if (ModelState.IsValid)
            {
                db.Entry(county).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(county);
        }

        //
        // GET: /County/Delete/5

        public ActionResult Delete(int id = 0)
        {
            County county = db.Countys.Find(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        //
        // POST: /County/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            County county = db.Countys.Find(id);
            db.Countys.Remove(county);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}