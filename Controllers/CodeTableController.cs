using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bipa.Models;
using System.Data.Sql;
using System.Data.SqlClient;
using Bipa.EditModels;

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

        //TRAIN_S_N  APP_FNAME   APP_LNAME
        [HttpPost]
        public ActionResult AddReferralDetails(ReferralList r1)
        {


            db.ReferralListInsert(r1.APP_NO, r1.TRAIN_S_N, r1.CodeID, r1.CaseDesc, r1.Remarks, r1.DepDay);
            return RedirectToAction("ReferralListView");
            //return View("ReferralForm", r1);
        }

        public ActionResult GetReferralList(string TRAIN_S_N, string APP_FNAME, string APP_LNAME)
        {

            //var result = new List<LatitudeLongitude>();
            //result = (from p in db.MaptestTable orderby p.DistrictName select p).ToList();
            //var viewModel = result.Select(x => new
            //{
            //    value = x.GLId,
            //    label = x.GLId

            //});

          
            //}
          //  if (APP_FNAME = 0) { APP_FNAME = null; }

            var result = db.Database.SqlQuery<AppGenInfo>(
                "exec VIPA.dbo.s_SearchforApplications @CourseNumber,@FirstName,@LastName",
                new SqlParameter("CourseNumber", TRAIN_S_N),
                  new SqlParameter("FirstName", APP_FNAME),
                  new SqlParameter("LastName", APP_LNAME)
                 

                  ).ToList<AppGenInfo>();

            //ViewBag.incidentCode = incidentcode;
            //ViewBag.startdate = startdate;
            //ViewBag.enddate = enddate;

            return PartialView("_PartialAppGenInfo", result);

        }

        public ActionResult ReferralListGeneralInquiry( string APP_FNAME, string APP_LNAME)
        {

            //var result = new List<LatitudeLongitude>();
            //result = (from p in db.MaptestTable orderby p.DistrictName select p).ToList();
            //var viewModel = result.Select(x => new
            //{
            //    value = x.GLId,
            //    label = x.GLId

            //});


            //}
            //  if (APP_FNAME = 0) { APP_FNAME = null; }

            if (APP_FNAME == null & APP_LNAME == null)
            {

                var result = db.Database.SqlQuery<ReferralListInquiry>(
                    "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                    new SqlParameter("FirstName", DBNull.Value),
                      new SqlParameter("LastName", DBNull.Value)


                      ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);
            }

            else if (APP_FNAME != null & APP_LNAME == null)
            {
                var result = db.Database.SqlQuery<ReferralListInquiry>(
                     "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                     new SqlParameter("FirstName", APP_FNAME),
                       new SqlParameter("LastName", DBNull.Value)


                       ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);


            }

            else if (APP_FNAME == null & APP_LNAME != null)
            {
                var result = db.Database.SqlQuery<ReferralListInquiry>(
                     "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                     new SqlParameter("FirstName", DBNull.Value),
                       new SqlParameter("LastName", APP_LNAME)


                       ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);


            }

            else
            {
                var result = db.Database.SqlQuery<ReferralListInquiry>(
                    "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                    new SqlParameter("FirstName", APP_FNAME),
                      new SqlParameter("LastName", APP_LNAME)


                      ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);
            }

            //var result = db.Database.SqlQuery<ReferralListInquiry>(
            //    "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",
                
            //      new SqlParameter("FirstName", APP_FNAME),
            //      new SqlParameter("LastName", APP_LNAME)


            //      ).ToList<ReferralListInquiry>();

            //ViewBag.incidentCode = incidentcode;
            //ViewBag.startdate = startdate;
            //ViewBag.enddate = enddate;

          

        }

        public ActionResult ReferralListGeneralInquiryMVC(ReferralListInquiry r1)
        {

            //var result = new List<LatitudeLongitude>();
            //result = (from p in db.MaptestTable orderby p.DistrictName select p).ToList();
            //var viewModel = result.Select(x => new
            //{
            //    value = x.GLId,
            //    label = x.GLId

            //});


            //}
            //  if (APP_FNAME = 0) { APP_FNAME = null; }

            //int FirstNameLen=r1.APP_FNAME.Length;
            if (r1.APP_FNAME == null & r1.APP_LNAME == null) {

                var result = db.Database.SqlQuery<ReferralListInquiry>(
                    "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                    new SqlParameter("FirstName", DBNull.Value),
                      new SqlParameter("LastName", DBNull.Value)


                      ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);
            }

            else if (r1.APP_FNAME != null & r1.APP_LNAME == null) {
                var result = db.Database.SqlQuery<ReferralListInquiry>(
                     "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                     new SqlParameter("FirstName", r1.APP_FNAME),
                       new SqlParameter("LastName", DBNull.Value)


                       ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);
            
            
            }

            else if (r1.APP_FNAME == null & r1.APP_LNAME != null)
            {
                var result = db.Database.SqlQuery<ReferralListInquiry>(
                     "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",
                     
                     new SqlParameter("FirstName", DBNull.Value),
                       new SqlParameter("LastName", r1.APP_LNAME)


                       ).ToList<ReferralListInquiry>();

                return PartialView("_RefListForInquiry", result);


            }

            else { 
            var result = db.Database.SqlQuery<ReferralListInquiry>(
                "exec VIPA.dbo.s_SearchforReferral @FirstName,@LastName",

                new SqlParameter("FirstName", r1.APP_FNAME),
                  new SqlParameter("LastName", r1.APP_LNAME)


                  ).ToList<ReferralListInquiry>();

            return PartialView("_RefListForInquiry", result);
            }



            //ViewBag.incidentCode = incidentcode;
            //ViewBag.startdate = startdate;
            //ViewBag.enddate = enddate;

            

        }

        
        public ActionResult ReferralViewForm(string APP_NO, string TRAIN_S_N, string APP_FNAME, string APP_LNAME)
        {

            ViewBag.APP_FNAME = APP_FNAME;
            ViewBag.APP_LNAME = APP_LNAME;
            ReferralList r1 = new ReferralList();
            r1.APP_NO = APP_NO;
            r1.TRAIN_S_N = TRAIN_S_N;
            return View("ReferralForm",r1);

        }
        //GeneralRefInquiry

        public ActionResult GeneralReferralInquiryForm()
        {

            return View("GeneralRefInquiry");



        }

        public ActionResult HallSeatTestView()
        {

            return View("HallSeatV1");



        }


        public ActionResult ReferralListView()
        {

            return View("SearchForm");



        }

        // GET: /CodeTable/Edit/5
        public ActionResult EditForReferral(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CodeTable codetable = db.CodeTables.Find(id);

            ReferralList r1 = db.ReferralListTable.Find(id);
            if (r1 == null)
            {
                return HttpNotFound();
            }
            return View("EditForReferral", r1);
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
            return View("Edit",codetable);
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
