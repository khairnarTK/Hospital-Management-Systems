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
    public class ManageDoctorsDepartmentsController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: ManageDoctorsDepartments
        public ActionResult Index()
        {
            return View(db.ManageDoctorsDepartments.ToList());
        }

        // GET: ManageDoctorsDepartments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageDoctorsDepartment manageDoctorsDepartment = db.ManageDoctorsDepartments.Find(id);
            if (manageDoctorsDepartment == null)
            {
                return HttpNotFound();
            }
            return View(manageDoctorsDepartment);
        }

        // GET: ManageDoctorsDepartments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageDoctorsDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Department_Name,Department_Description")] ManageDoctorsDepartment manageDoctorsDepartment)
        {
            if (ModelState.IsValid)
            {
                db.ManageDoctorsDepartments.Add(manageDoctorsDepartment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manageDoctorsDepartment);
        }

        // GET: ManageDoctorsDepartments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageDoctorsDepartment manageDoctorsDepartment = db.ManageDoctorsDepartments.Find(id);
            if (manageDoctorsDepartment == null)
            {
                return HttpNotFound();
            }
            return View(manageDoctorsDepartment);
        }

        // POST: ManageDoctorsDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Department_Name,Department_Description")] ManageDoctorsDepartment manageDoctorsDepartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manageDoctorsDepartment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manageDoctorsDepartment);
        }

        // GET: ManageDoctorsDepartments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageDoctorsDepartment manageDoctorsDepartment = db.ManageDoctorsDepartments.Find(id);
            if (manageDoctorsDepartment == null)
            {
                return HttpNotFound();
            }
            return View(manageDoctorsDepartment);
        }

        // POST: ManageDoctorsDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManageDoctorsDepartment manageDoctorsDepartment = db.ManageDoctorsDepartments.Find(id);
            db.ManageDoctorsDepartments.Remove(manageDoctorsDepartment);
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
