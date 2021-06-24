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
    public class SendForMajorsController : Controller
    {
        private SalinoContext db = new SalinoContext();

        // GET: Admin/SendForMajors
        public ActionResult Index()
        {
            return View(db.SendForMajors.ToList());
        }

        // GET: Admin/SendForMajors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SendForMajor sendForMajor = db.SendForMajors.Find(id);
            if (sendForMajor == null)
            {
                return HttpNotFound();
            }
            return View(sendForMajor);
        }

        // GET: Admin/SendForMajors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SendForMajors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameHaml,PriceHaml")] SendForMajor sendForMajor)
        {
            if (ModelState.IsValid)
            {
                db.SendForMajors.Add(sendForMajor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sendForMajor);
        }

        // GET: Admin/SendForMajors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SendForMajor sendForMajor = db.SendForMajors.Find(id);
            if (sendForMajor == null)
            {
                return HttpNotFound();
            }
            return View(sendForMajor);
        }

        // POST: Admin/SendForMajors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameHaml,PriceHaml")] SendForMajor sendForMajor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sendForMajor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sendForMajor);
        }

        // GET: Admin/SendForMajors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SendForMajor sendForMajor = db.SendForMajors.Find(id);
            if (sendForMajor == null)
            {
                return HttpNotFound();
            }
            return View(sendForMajor);
        }

        // POST: Admin/SendForMajors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SendForMajor sendForMajor = db.SendForMajors.Find(id);
            db.SendForMajors.Remove(sendForMajor);
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
