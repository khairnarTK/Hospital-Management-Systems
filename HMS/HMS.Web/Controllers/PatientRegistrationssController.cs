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
    public class PatientRegistrationssController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: PatientRegistrationss
        public ActionResult Index()
        {
            return View(db.PatientRegistrationes.ToList());
        }

        // GET: PatientRegistrationss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientRegistrations patientRegistrations = db.PatientRegistrationes.Find(id);
            if (patientRegistrations == null)
            {
                return HttpNotFound();
            }
            return View(patientRegistrations);
        }

        // GET: PatientRegistrationss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientRegistrationss/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_Name,Age,Gender,Blood_Group,Address,DOB,MobileNo,EmailAdd,Disease,DateOfJoin")] PatientRegistrations patientRegistrations)
        {
            if (ModelState.IsValid)
            {
                db.PatientRegistrationes.Add(patientRegistrations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientRegistrations);
        }

        // GET: PatientRegistrationss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientRegistrations patientRegistrations = db.PatientRegistrationes.Find(id);
            if (patientRegistrations == null)
            {
                return HttpNotFound();
            }
            return View(patientRegistrations);
        }

        // POST: PatientRegistrationss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Last_Name,Age,Gender,Blood_Group,Address,DOB,MobileNo,EmailAdd,Disease,DateOfJoin")] PatientRegistrations patientRegistrations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientRegistrations).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientRegistrations);
        }

        // GET: PatientRegistrationss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientRegistrations patientRegistrations = db.PatientRegistrationes.Find(id);
            if (patientRegistrations == null)
            {
                return HttpNotFound();
            }
            return View(patientRegistrations);
        }

        // POST: PatientRegistrationss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientRegistrations patientRegistrations = db.PatientRegistrationes.Find(id);
            db.PatientRegistrationes.Remove(patientRegistrations);
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
