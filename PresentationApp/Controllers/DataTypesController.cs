using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PresentationApp.Models;
using PresentationApp.ErrorHandling;

namespace PresentationApp.Controllers
{
    public class DataTypesController : Controller
    {
        private PresentationDbContext db = new PresentationDbContext();

        // GET: DataTypes
        public ActionResult Index([Bind(Prefix = "Id")] int presentationId)
        {
            var presentation = db.Presentations.Find(presentationId);

            if(presentation == null)
            {
                return HttpNotFound();
            }

            return View(presentation);
        }

        // GET: DataTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataTypes DataTypes = db.Examples.Find(id);
            if (DataTypes == null)
            {
                return HttpNotFound();
            }
            return View(DataTypes);
        }

        // GET: DataTypes/Create
        public ActionResult Create(int presentationId)
        {
            return View();
        }

        // POST: DataTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstInteger,SecondInteger,FirstDouble,SecondDouble,FirstFloat,SecondFloat,PresentationId")] DataTypes DataTypes)
        {
            var errors = ModelState.GetErrors();

            if (ModelState.IsValid)
            {
                db.Examples.Add(DataTypes);
                db.SaveChanges();
                return RedirectToAction("Index", new { Id = DataTypes.PresentationId });
            }

            return View(DataTypes);
        }

        // GET: DataTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataTypes DataTypes = db.Examples.Find(id);
            if (DataTypes == null)
            {
                return HttpNotFound();
            }
            return View(DataTypes);
        }

        // POST: DataTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstInteger,SecondInteger,FirstDouble,SecondDouble,FirstFloat,SecondFloat,PresentationId")] DataTypes DataTypes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(DataTypes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { Id = DataTypes.Id });
            }
            return View(DataTypes);
        }

        // GET: DataTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataTypes DataTypes = db.Examples.Find(id);
            if (DataTypes == null)
            {
                return HttpNotFound();
            }
            return View(DataTypes);
        }

        // POST: DataTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataTypes DataTypes = db.Examples.Find(id);
            db.Examples.Remove(DataTypes);
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
