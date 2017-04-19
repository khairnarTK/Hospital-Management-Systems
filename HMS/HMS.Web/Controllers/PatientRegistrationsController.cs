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
            return View(db.PatientRegistrationes.ToList());
        }

        // GET: PatientRegistrations/Details/5
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
        public ActionResult Create([Bind(Include = "Id,First_Name,Middle_Name,Last_Name,City,Address,Date_Of_Birth,Age,Gender,Maritial_Status,Occupation,Blood_Group,MobileNo,EmailAdd,Disease,Date_Of_Join,Department,Ward_Name,Bed_No")] PatientRegistrations patientRegistrations)
        {
            if (ModelState.IsValid)
            {
                db.PatientRegistrationes.Add(patientRegistrations);
               // db.Entry(patientRegistrations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientRegistrations);
        }

        // GET: PatientRegistrations/Edit/5
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

        // POST: PatientRegistrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Middle_Name,Last_Name,City,Address,Date_Of_Birth,Age,Gender,Maritial_Status,Occupation,Blood_Group,MobileNo,EmailAdd,Disease,Date_Of_Join,Department,Ward_Name,Bed_No")] PatientRegistrations patientRegistrations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientRegistrations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientRegistrations);
        }

        // GET: PatientRegistrations/Delete/5
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

        // POST: PatientRegistrations/Delete/5
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
