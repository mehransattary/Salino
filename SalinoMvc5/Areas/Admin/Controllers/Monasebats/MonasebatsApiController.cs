using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Salino.DataLayer;
using Salino.Models;

namespace SalinoMvc5.Areas.Admin.Controllers.Monasebats
{
    public class MonasebatsApiController : ApiController
    {
        private SalinoContext db = new SalinoContext();

        // GET: api/MonasebatsApi
        public IQueryable<Monasebat> GetMonasebats()
        {
            return db.Monasebats;
        }

        // GET: api/MonasebatsApi/5
        [ResponseType(typeof(Monasebat))]
        public IHttpActionResult GetMonasebat(int id)
        {
            Monasebat monasebat = db.Monasebats.Find(id);
            if (monasebat == null)
            {
                return NotFound();
            }

            return Ok(monasebat);
        }

        // PUT: api/MonasebatsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMonasebat(int id, Monasebat monasebat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monasebat.Id)
            {
                return BadRequest();
            }

            db.Entry(monasebat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonasebatExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MonasebatsApi
        [ResponseType(typeof(Monasebat))]
        public void PostMonasebat(Monasebat monasebat)
        {
           

            db.Monasebats.Add(monasebat);
            db.SaveChanges();

           
        }

        // DELETE: api/MonasebatsApi/5
        [ResponseType(typeof(Monasebat))]
        public IHttpActionResult DeleteMonasebat(int id)
        {
            Monasebat monasebat = db.Monasebats.Find(id);
            if (monasebat == null)
            {
                return NotFound();
            }

            db.Monasebats.Remove(monasebat);
            db.SaveChanges();

            return Ok(monasebat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MonasebatExists(int id)
        {
            return db.Monasebats.Count(e => e.Id == id) > 0;
        }
    }
}