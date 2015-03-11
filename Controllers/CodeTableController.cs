using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bipa.Models;

namespace Bipa.Controllers
{
    public class CodeTableController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /CodeTable/
        public ActionResult Index()
        {
            return View(db.CodeTables.ToList());
        }

        // GET: /CodeTable/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeTable codetable = db.CodeTables.Find(id);
            if (codetable == null)
            {
                return HttpNotFound();
            }
            return View(codetable);
        }

        // GET: /CodeTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /CodeTable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CodeID,CodeType,CodeSeverity,CodeDescription")] CodeTable codetable)
        {
            if (ModelState.IsValid)
            {
                db.CodeTables.Add(codetable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codetable);
        }

        // GET: /CodeTable/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeTable codetable = db.CodeTables.Find(id);
            if (codetable == null)
            {
                return HttpNotFound();
            }
            return View(codetable);
        }

        // POST: /CodeTable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CodeID,CodeType,CodeSeverity,CodeDescription")] CodeTable codetable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codetable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codetable);
        }

        // GET: /CodeTable/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeTable codetable = db.CodeTables.Find(id);
            if (codetable == null)
            {
                return HttpNotFound();
            }
            return View(codetable);
        }

        // POST: /CodeTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CodeTable codetable = db.CodeTables.Find(id);
            db.CodeTables.Remove(codetable);
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
