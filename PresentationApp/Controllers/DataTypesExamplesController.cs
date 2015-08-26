using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PresentationApp.Models;

namespace PresentationApp.Controllers
{
    public class DataTypesExamplesController : Controller
    {
        private PresentationDbContext db = new PresentationDbContext();

        // GET: DataTypesExamples
        public ActionResult Index([Bind(Prefix = "Id")] int presentationId)
        {
            var presentation = db.Presentations.Find(presentationId);

            if(presentation == null)
            {
                return HttpNotFound();
            }

            return View(presentation);
        }

        // GET: DataTypesExamples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataTypesExample dataTypesExample = db.Examples.Find(id);
            if (dataTypesExample == null)
            {
                return HttpNotFound();
            }
            return View(dataTypesExample);
        }

        // GET: DataTypesExamples/Create
        public ActionResult Create(int presentationId)
        {
            return View();
        }

        // POST: DataTypesExamples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstInteger,SecondInteger,FirstDouble,SecondDouble,FirstFloat,SecondFloat,PresentationId")] DataTypesExample dataTypesExample)
        {
            if (ModelState.IsValid)
            {
                db.Examples.Add(dataTypesExample);
                db.SaveChanges();
                return RedirectToAction("Index", new { Id = dataTypesExample.PresentationId });
            }

            return View(dataTypesExample);
        }

        // GET: DataTypesExamples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataTypesExample dataTypesExample = db.Examples.Find(id);
            if (dataTypesExample == null)
            {
                return HttpNotFound();
            }
            return View(dataTypesExample);
        }

        // POST: DataTypesExamples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstInteger,SecondInteger,FirstDouble,SecondDouble,FirstFloat,SecondFloat,PresentationId")] DataTypesExample dataTypesExample)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataTypesExample).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { Id = dataTypesExample.Id });
            }
            return View(dataTypesExample);
        }

        // GET: DataTypesExamples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataTypesExample dataTypesExample = db.Examples.Find(id);
            if (dataTypesExample == null)
            {
                return HttpNotFound();
            }
            return View(dataTypesExample);
        }

        // POST: DataTypesExamples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataTypesExample dataTypesExample = db.Examples.Find(id);
            db.Examples.Remove(dataTypesExample);
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
