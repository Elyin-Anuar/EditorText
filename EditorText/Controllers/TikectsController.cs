using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EditorText.Models;

namespace EditorText.Controllers
{
    public class TikectsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tikects
        public ActionResult Index()
        {
            return View(db.Tikects.ToList());
        }

        // GET: Tikects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tikect tikect = db.Tikects.Find(id);
            if (tikect == null)
            {
                return HttpNotFound();
            }
            return View(tikect);
        }

        // GET: Tikects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tikects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TikectId,TypeIncident,DescriptionIncident,DateIncident,DocumentImage")] Tikect tikect)
        {
            if (ModelState.IsValid)
            {
                db.Tikects.Add(tikect);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tikect);
        }

        // GET: Tikects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tikect tikect = db.Tikects.Find(id);
            if (tikect == null)
            {
                return HttpNotFound();
            }
            return View(tikect);
        }

        // POST: Tikects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TikectId,TypeIncident,DescriptionIncident,DateIncident,DocumentImage")] Tikect tikect)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tikect).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tikect);
        }

        // GET: Tikects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tikect tikect = db.Tikects.Find(id);
            if (tikect == null)
            {
                return HttpNotFound();
            }
            return View(tikect);
        }

        // POST: Tikects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tikect tikect = db.Tikects.Find(id);
            db.Tikects.Remove(tikect);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
