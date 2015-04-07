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
    public class ReferralTableController : Controller
    {
        private MvcDbContext db = new MvcDbContext();

        // GET: /ReferralTable/
        public ActionResult Index()
        {
            return View(db.ReferralTables.ToList());
        }

        public ActionResult GeneralReferralInquiryForm()
        {

            return View("GeneralRefInquiry");



        }

        // GET: /ReferralTable/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralTable referraltable = db.ReferralTables.Find(id);
            if (referraltable == null)
            {
                return HttpNotFound();
            }
            return View(referraltable);
        }

        // GET: /ReferralTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ReferralTable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="RecordID,APP_NO,TRAIN_S_N,CodeID,DepDay,CaseDesc,Remarks")] ReferralTable referraltable)
        {
            if (ModelState.IsValid)
            {
                db.ReferralTables.Add(referraltable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referraltable);
        }

        // GET: /ReferralTable/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralTable referraltable = db.ReferralTables.Find(id);
            if (referraltable == null)
            {
                return HttpNotFound();
            }
            return View(referraltable);
        }

        // POST: /ReferralTable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="RecordID,APP_NO,TRAIN_S_N,CodeID,DepDay,CaseDesc,Remarks")] ReferralTable referraltable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referraltable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referraltable);
        }

        // GET: /ReferralTable/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralTable referraltable = db.ReferralTables.Find(id);
            if (referraltable == null)
            {
                return HttpNotFound();
            }
            return View(referraltable);
        }

        // POST: /ReferralTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ReferralTable referraltable = db.ReferralTables.Find(id);
            db.ReferralTables.Remove(referraltable);
            db.SaveChanges();
            return RedirectToAction("GeneralReferralInquiryForm");
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
