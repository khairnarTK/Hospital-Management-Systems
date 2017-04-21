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
    public class ManageReceptionsController : Controller
    {
        private HmsContext db = new HmsContext();

        // GET: ManageReceptions
        public ActionResult Index()
        {
            return View(db.ManageReceptions.ToList());
        }

        // GET: ManageReceptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageReception manageReception = db.ManageReceptions.Find(id);
            if (manageReception == null)
            {
                return HttpNotFound();
            }
            return View(manageReception);
        }

        // GET: ManageReceptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageReceptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_Name,Email,Address,Phone")] ManageReception manageReception)
        {
            if (ModelState.IsValid)
            {
                db.ManageReceptions.Add(manageReception);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manageReception);
        }

        // GET: ManageReceptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageReception manageReception = db.ManageReceptions.Find(id);
            if (manageReception == null)
            {
                return HttpNotFound();
            }
            return View(manageReception);
        }

        // POST: ManageReceptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Last_Name,Email,Address,Phone")] ManageReception manageReception)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manageReception).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manageReception);
        }

        // GET: ManageReceptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageReception manageReception = db.ManageReceptions.Find(id);
            if (manageReception == null)
            {
                return HttpNotFound();
            }
            return View(manageReception);
        }

        // POST: ManageReceptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManageReception manageReception = db.ManageReceptions.Find(id);
            db.ManageReceptions.Remove(manageReception);
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
