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
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Students
        public ActionResult Index(StudentSearchModel pg)
        {
            var students = db.Students.AsQueryable();
            if (pg == null) pg = new StudentSearchModel();
            if (!string.IsNullOrEmpty(pg.sid))
            {
                students = students.Where(i => i.SID == pg.sid);
            }
            if (!string.IsNullOrEmpty(pg.Name))
            {
                students =
                    students.Where(
                        i => i.FNAME.Contains(pg.Name) || i.LNAME.Contains(pg.Name) || i.MNAME.Contains(pg.Name));

            }
            var rec = students.OrderBy(i => new { i.FNAME, i.MNAME, i.LNAME, i.SID })
                .ToPagedList(pg.page.Value, pg.size.Value);
            ViewBag.SearchOptions = pg;
            return View(rec);
        }
        // GET: Students/Details/5
       
        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SID,FNAME,MNAME,LNAME,FOREIGNER,ADDRE,DOB,OCC,EDUCATION,TEL1,TEL2,EMAIL,REMARKS,TENSNG,TENSP,TEN,SEVEN,TWENTY,THIRTY,FOURTYFIVE,SIXTY,SERVED,INTRODUCEDBY,SEX")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Edit",new{id=student.ID});
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SID,FNAME,MNAME,LNAME,FOREIGNER,ADDRE,DOB,OCC,EDUCATION,TEL1,TEL2,EMAIL,REMARKS,TENSNG,TENSP,TEN,SEVEN,TWENTY,THIRTY,FOURTYFIVE,SIXTY,SERVED,INTRODUCEDBY,SEX")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", new { id = student.ID });
            }
            return View(student);
        }
        [HttpPost]
        public ActionResult DeleteRecord(int id)
        {

            var jsonResult = new JsonResult();

            int storeId = db.Students.Where(i => i.ID == id).Delete();
            if (storeId == 0)
            {
                jsonResult.Data = new { result = "FAIL", message = "Could not find Student" };
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
