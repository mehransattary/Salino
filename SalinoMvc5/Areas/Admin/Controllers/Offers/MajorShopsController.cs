using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Salino.DataLayer;
using Salino.Models;

namespace SalinoMvc5.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin1")]
    public class MajorShopsController : Controller
    {
        private SalinoContext db = new SalinoContext();

        // GET: Admin/MajorShops
        public ActionResult Index()
        {
            var majorShops = db.MajorShops.Include(m => m.FarbicType);
            return View(majorShops.ToList());
        }

        // GET: Admin/MajorShops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MajorShop majorShop = db.MajorShops.Find(id);
            if (majorShop == null)
            {
                return HttpNotFound();
            }
            return View(majorShop);
        }

        // GET: Admin/MajorShops/Create
        public ActionResult Create()
        {
            ViewBag.FarbicId = new SelectList(db.FarbicTypes, "Id", "tiltle");
            return View();
        }

        // POST: Admin/MajorShops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MinSelectedProduct,Count,FarbicId,PriceMajor,Createdate")] MajorShop majorShop)
        {
            if (ModelState.IsValid)
            {
                var firstresult = db.MajorShops.OrderBy(x=>x.Id).FirstOrDefault();
                if (firstresult != null)
                {
                    majorShop.MinSelectedProduct = firstresult.MinSelectedProduct;
                    majorShop.Count = firstresult.Count;
                }
               
                db.MajorShops.Add(majorShop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FarbicId = new SelectList(db.FarbicTypes, "Id", "tiltle", majorShop.FarbicId);
            return View(majorShop);
        }

        // GET: Admin/MajorShops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MajorShop majorShop = db.MajorShops.Find(id);
            if (majorShop == null)
            {
                return HttpNotFound();
            }
            ViewBag.FarbicId = new SelectList(db.FarbicTypes, "Id", "tiltle", majorShop.FarbicId);
            return View(majorShop);
        }

        // POST: Admin/MajorShops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MinSelectedProduct,Count,FarbicId,PriceMajor,Createdate")] MajorShop majorShop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(majorShop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FarbicId = new SelectList(db.FarbicTypes, "Id", "tiltle", majorShop.FarbicId);
            return View(majorShop);
        }

        // GET: Admin/MajorShops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MajorShop majorShop = db.MajorShops.Find(id);
            if (majorShop == null)
            {
                return HttpNotFound();
            }
            return View(majorShop);
        }

        // POST: Admin/MajorShops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MajorShop majorShop = db.MajorShops.Find(id);
            db.MajorShops.Remove(majorShop);
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
