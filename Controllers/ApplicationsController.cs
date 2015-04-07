using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Bipa.EditModels;
using Bipa.Models;
using Bipa.SearchModels;
using EntityFramework.Extensions;
using PagedList;

namespace Bipa.Controllers
{
    [Authorize]
    public class ApplicationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ApplicationsController():base()
        {
            Mapper.CreateMap<Application, AppContactInfo>();
            Mapper.CreateMap<AppContactInfo, Application>();
        }
        public ActionResult Index(ApplicationSearchModel pg)
        {
            var applications = db.Applications.AsQueryable();
            if (pg == null) pg = new ApplicationSearchModel();
            if (!string.IsNullOrEmpty(pg.App_no))
            {
                applications = applications.Where(i => i.APP_NO == pg.App_no);
            }
            if (!string.IsNullOrEmpty(pg.Reg_no))
            {
                applications = applications.Where(i => i.REG_NO == pg.Reg_no);
            }
            if (!string.IsNullOrEmpty(pg.Name))
            {
                applications =
                    applications.Where(
                        i => i.APP_FNAME.Contains(pg.Name) || i.APP_MNAME.Contains(pg.Name) || i.APP_LNAME.Contains(pg.Name));

            }
            var rec = applications.OrderBy(i => new { i.APP_FNAME, i.APP_MNAME, i.APP_LNAME, i.APP_NO })
                .ToPagedList(pg.page.Value, pg.size.Value);
            ViewBag.SearchOptions = pg;
            return View(rec);
        }
       

        // GET: Applications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ApplicationEM appEM)
        {
            if (ModelState.IsValid)
            {
                var app= new Application();
                AppGenInfo.CopyInfoToEntity(appEM.AppGenInfo, app);
                AppContactInfo.CopyToEntity(appEM.AppContactInfo, app);
                AppHealthInfo.CopyInfoToEntity(appEM.AppHealthInfo, app);
                AppExtraInfo.CopyToEntity(appEM.AppExtraInfo, app);
                AppHistoryInfo.CopyInfoToEntity(appEM.AppHistoryInfo, app);
                AppTrainInfo.CopyToEntity(appEM.AppTrainInfo, app);
                
                db.Applications.Add(app);
                db.SaveChanges();
                return RedirectToAction("Edit",new{id=app.ID});
            }
            return View(appEM);
        }

        // GET: Applications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            //var appGenInfo = Mapper.Map<Application,AppContactInfo>(application);
            var appem = new ApplicationEM()
            {
                ID = application.ID,
                AppGenInfo = AppGenInfo.CopyInfoFromEntity(application),
                AppContactInfo = Mapper.Map<Application, AppContactInfo>(application),
                AppExtraInfo = AppExtraInfo.CopyFromEntity(application),
                AppHistoryInfo = AppHistoryInfo.CopyInfoFromEntity(application),
                AppHealthInfo = AppHealthInfo.CopyInfoFromEntity(application),
                AppTrainInfo = AppTrainInfo.CopyInfoFromEntity(application)
            };
            return View(appem);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationEM appEM)
        {
            if (ModelState.IsValid)
            {
                var app = db.Applications.Find(appEM.ID);
                if (app == null)
                {
                    return HttpNotFound();
                }
                AppGenInfo.CopyInfoToEntity(appEM.AppGenInfo,app);
                AppContactInfo.CopyToEntity(appEM.AppContactInfo,app);
                AppHealthInfo.CopyInfoToEntity(appEM.AppHealthInfo, app);
                AppExtraInfo.CopyToEntity(appEM.AppExtraInfo, app);
                AppHistoryInfo.CopyInfoToEntity(appEM.AppHistoryInfo, app);
                AppTrainInfo.CopyToEntity(appEM.AppTrainInfo, app);
                
                db.SaveChanges();
                return RedirectToAction("Edit", new {id = appEM.ID});
                //db.Entry(application).State = EntityState.Modified;
                //db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return View(appEM);
        }
        [HttpPost]
        public ActionResult DeleteRecord(int id)
        {
            
            var jsonResult = new JsonResult();
           
            int storeId = db.Applications.Where(i => i.ID == id ).Delete();
            if (storeId == 0)
            {
                jsonResult.Data = new { result = "FAIL", message = "Could not find Application" };
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
