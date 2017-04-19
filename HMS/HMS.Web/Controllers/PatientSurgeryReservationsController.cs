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
    public class PatientSurgeryReservationsController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: PatientSurgeryReservations
        public ActionResult Index()
        {
            return View(db.PatientSurgeryReservations.ToList());
        }

        // GET: PatientSurgeryReservations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientSurgeryReservation patientSurgeryReservation = db.PatientSurgeryReservations.Find(id);
            if (patientSurgeryReservation == null)
            {
                return HttpNotFound();
            }
            return View(patientSurgeryReservation);
        }

        // GET: PatientSurgeryReservations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientSurgeryReservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Patient_Id,OT_ID,Patient_Name,Assign_Doctor,Symtoms,Risk_Factor,Surgery_Type,Guardians_Name,Guardians_Relation,Surgery_Date,Start_Time,Ot_Total_hr,End_Time,OT_Amount,Deposit_Amount,Balance")] PatientSurgeryReservation patientSurgeryReservation)
        {
            if (ModelState.IsValid)
            {
                db.PatientSurgeryReservations.Add(patientSurgeryReservation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientSurgeryReservation);
        }

        // GET: PatientSurgeryReservations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientSurgeryReservation patientSurgeryReservation = db.PatientSurgeryReservations.Find(id);
            if (patientSurgeryReservation == null)
            {
                return HttpNotFound();
            }
            return View(patientSurgeryReservation);
        }

        // POST: PatientSurgeryReservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Patient_Id,OT_ID,Patient_Name,Assign_Doctor,Symtoms,Risk_Factor,Surgery_Type,Guardians_Name,Guardians_Relation,Surgery_Date,Start_Time,Ot_Total_hr,End_Time,OT_Amount,Deposit_Amount,Balance")] PatientSurgeryReservation patientSurgeryReservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientSurgeryReservation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientSurgeryReservation);
        }

        // GET: PatientSurgeryReservations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientSurgeryReservation patientSurgeryReservation = db.PatientSurgeryReservations.Find(id);
            if (patientSurgeryReservation == null)
            {
                return HttpNotFound();
            }
            return View(patientSurgeryReservation);
        }

        // POST: PatientSurgeryReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientSurgeryReservation patientSurgeryReservation = db.PatientSurgeryReservations.Find(id);
            db.PatientSurgeryReservations.Remove(patientSurgeryReservation);
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
