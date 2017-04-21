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
    public class ManageDoctorsController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: ManageDoctors
        public ActionResult Index()
        {
            return View(db.ManageDoctors.ToList());
        }

        // GET: ManageDoctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageDoctors manageDoctors = db.ManageDoctors.Find(id);
            if (manageDoctors == null)
            {
                return HttpNotFound();
            }
            return View(manageDoctors);
        }

        // GET: ManageDoctors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageDoctors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_Name,Email,Address,Phone,Qualification,Department_Id,Profile")] ManageDoctors manageDoctors)
        {
            if (ModelState.IsValid)
            {
                db.ManageDoctors.Add(manageDoctors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manageDoctors);
        }

        // GET: ManageDoctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageDoctors manageDoctors = db.ManageDoctors.Find(id);
            if (manageDoctors == null)
            {
                return HttpNotFound();
            }
            return View(manageDoctors);
        }

        // POST: ManageDoctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Last_Name,Email,Address,Phone,Qualification,Department_Id,Profile")] ManageDoctors manageDoctors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manageDoctors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manageDoctors);
        }

        // GET: ManageDoctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageDoctors manageDoctors = db.ManageDoctors.Find(id);
            if (manageDoctors == null)
            {
                return HttpNotFound();
            }
            return View(manageDoctors);
        }

        // POST: ManageDoctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManageDoctors manageDoctors = db.ManageDoctors.Find(id);
            db.ManageDoctors.Remove(manageDoctors);
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
