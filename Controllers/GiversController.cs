﻿using System;
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
    public class GiversController : Controller
    {
        private MIS4200Team1Context db = new MIS4200Team1Context();

        // GET: Givers
        public ActionResult Index()
        {
            return View(db.Givers.ToList());
        }

        // GET: Givers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giver giver = db.Givers.Find(id);
            if (giver == null)
            {
                return HttpNotFound();
            }
            return View(giver);
        }

        // GET: Givers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Givers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "giverID,gratitudeId,award,recognizor,recognized,recognizationDate")] Giver giver)
        {
            if (ModelState.IsValid)
            {
                db.Givers.Add(giver);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giver);
        }

        // GET: Givers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giver giver = db.Givers.Find(id);
            if (giver == null)
            {
                return HttpNotFound();
            }
            return View(giver);
        }

        // POST: Givers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "giverID,gratitudeId,award,recognizor,recognized,recognizationDate")] Giver giver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giver).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giver);
        }

        // GET: Givers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giver giver = db.Givers.Find(id);
            if (giver == null)
            {
                return HttpNotFound();
            }
            return View(giver);
        }

        // POST: Givers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Giver giver = db.Givers.Find(id);
            db.Givers.Remove(giver);
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