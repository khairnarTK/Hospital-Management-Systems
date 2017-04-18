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
    public class PatientRegistrationsController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: PatientRegistrations
        public ActionResult Index()
        {
            return View(db.PatientRegistrations.ToList());
        }

        // GET: PatientRegistrations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientRegistration patientRegistration = db.PatientRegistrations.Find(id);
            if (patientRegistration == null)
            {
                return HttpNotFound();
            }
            return View(patientRegistration);
        }

        // GET: PatientRegistrations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientRegistrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,DOB,MobileNo,EmailAdd,DateOfJoin")] PatientRegistration patientRegistration)
        {
            if (ModelState.IsValid)
            {
                db.PatientRegistrations.Add(patientRegistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientRegistration);
        }

        // GET: PatientRegistrations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientRegistration patientRegistration = db.PatientRegistrations.Find(id);
            if (patientRegistration == null)
            {
                return HttpNotFound();
            }
            return View(patientRegistration);
        }

        // POST: PatientRegistrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,DOB,MobileNo,EmailAdd,DateOfJoin")] PatientRegistration patientRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientRegistration).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientRegistration);
        }

        // GET: PatientRegistrations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientRegistration patientRegistration = db.PatientRegistrations.Find(id);
            if (patientRegistration == null)
            {
                return HttpNotFound();
            }
            return View(patientRegistration);
        }

        // POST: PatientRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientRegistration patientRegistration = db.PatientRegistrations.Find(id);
            db.PatientRegistrations.Remove(patientRegistration);
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
