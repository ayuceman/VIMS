using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bipa.Models;
using Bipa.SearchModels;
using EntityFramework.Extensions;
using PagedList;

namespace Bipa.Controllers
{
    [Authorize]
    public class TeachersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Teachers
        public ActionResult Index(TeacherSearchModel pg)
        {
            var teachers = db.Teachers.AsQueryable();
            if(pg==null)pg=new TeacherSearchModel();
            if (!string.IsNullOrEmpty(pg.tid))
            {
                teachers = teachers.Where(i => i.TID == pg.tid);
            }
            if (!string.IsNullOrEmpty(pg.Name))
            {
                teachers =
                    teachers.Where(
                        i => i.FNAME.Contains(pg.Name) || i.LNAME.Contains(pg.Name) || i.MNAME.Contains(pg.Name));

            }
            var rec = teachers.OrderBy(i => new {i.FNAME, i.MNAME, i.LNAME, i.TID})
                .ToPagedList(pg.page.Value, pg.size.Value);
            ViewBag.SearchOptions = pg;
            return View(rec);
        }

        // GET: Teachers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: Teachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TID,SID,DEGIGNATION,FNAME,MNAME,LNAME,DOB,NDOB,OCC,EDUCATION,ADDR,TEL1,TEL2,EMAIL,REMARKS,TENSP,TENSNG,TEN,SEVEN,TWENTY,THIRTY,FOURTYFIVE,SIXTY,TSC45,TSC30,SERVED,INTRODUCEDBY,SEX,FROMS,APP_NDATE,APP_DATE")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Edit", new { id = teacher.ID });
            }

            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TID,SID,DEGIGNATION,FNAME,MNAME,LNAME,DOB,NDOB,OCC,EDUCATION,ADDR,TEL1,TEL2,EMAIL,REMARKS,TENSP,TENSNG,TEN,SEVEN,TWENTY,THIRTY,FOURTYFIVE,SIXTY,TSC45,TSC30,SERVED,INTRODUCEDBY,SEX,FROMS,APP_NDATE,APP_DATE")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", new { id = teacher.ID });
            }
            return View(teacher);
        }
        [HttpPost]
        public ActionResult DeleteRecord(int id)
        {

            var jsonResult = new JsonResult();

            int storeId = db.Teachers.Where(i => i.ID == id).Delete();
            if (storeId == 0)
            {
                jsonResult.Data = new { result = "FAIL", message = "Could not find Teacher" };
                return jsonResult;
            }
            jsonResult.Data = new { result = "OK", message = "Deleted Successfully" };
            return jsonResult;
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
