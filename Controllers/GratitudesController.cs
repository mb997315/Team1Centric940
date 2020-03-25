using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Team1Centric940.DAL;
using Team1Centric940.Models;

namespace Team1Centric940.Controllers
{
    public class GratitudesController : Controller
    {
        private MIS4200Team1Context db = new MIS4200Team1Context();

        // GET: Gratitudes
        public ActionResult Index()
        {
            return View(db.Gratitudes.ToList());
        }

        // GET: Gratitudes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gratitude gratitude = db.Gratitudes.Find(id);
            if (gratitude == null)
            {
                return HttpNotFound();
            }
            return View(gratitude);
        }

        // GET: Gratitudes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gratitudes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gratitudeId,giverID")] Gratitude gratitude)
        {
            if (ModelState.IsValid)
            {
                db.Gratitudes.Add(gratitude);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gratitude);
        }

        // GET: Gratitudes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gratitude gratitude = db.Gratitudes.Find(id);
            if (gratitude == null)
            {
                return HttpNotFound();
            }
            return View(gratitude);
        }

        // POST: Gratitudes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gratitudeId,giverID")] Gratitude gratitude)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gratitude).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gratitude);
        }

        // GET: Gratitudes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gratitude gratitude = db.Gratitudes.Find(id);
            if (gratitude == null)
            {
                return HttpNotFound();
            }
            return View(gratitude);
        }

        // POST: Gratitudes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gratitude gratitude = db.Gratitudes.Find(id);
            db.Gratitudes.Remove(gratitude);
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
