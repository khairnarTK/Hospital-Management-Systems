using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HMS.Web.Models;

namespace HMS.Web.Controllers
{
    public class OpeartionTheatresController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: OpeartionTheatres
        public ActionResult Index()
        {
            return View(db.OpeartionTheatres.ToList());
        }

        // GET: OpeartionTheatres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpeartionTheatre opeartionTheatre = db.OpeartionTheatres.Find(id);
            if (opeartionTheatre == null)
            {
                return HttpNotFound();
            }
            return View(opeartionTheatre);
        }

        // GET: OpeartionTheatres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OpeartionTheatres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OprationTheatre_Name,OT_Descrition")] OpeartionTheatre opeartionTheatre)
        {
            if (ModelState.IsValid)
            {
                db.OpeartionTheatres.Add(opeartionTheatre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opeartionTheatre);
        }

        // GET: OpeartionTheatres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpeartionTheatre opeartionTheatre = db.OpeartionTheatres.Find(id);
            if (opeartionTheatre == null)
            {
                return HttpNotFound();
            }
            return View(opeartionTheatre);
        }

        // POST: OpeartionTheatres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OprationTheatre_Name,OT_Descrition")] OpeartionTheatre opeartionTheatre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(opeartionTheatre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opeartionTheatre);
        }

        // GET: OpeartionTheatres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpeartionTheatre opeartionTheatre = db.OpeartionTheatres.Find(id);
            if (opeartionTheatre == null)
            {
                return HttpNotFound();
            }
            return View(opeartionTheatre);
        }

        // POST: OpeartionTheatres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OpeartionTheatre opeartionTheatre = db.OpeartionTheatres.Find(id);
            db.OpeartionTheatres.Remove(opeartionTheatre);
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
