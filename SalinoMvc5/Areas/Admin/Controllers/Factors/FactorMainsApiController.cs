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

namespace SalinoMvc5.Areas.Admin.Controllers.Factors
{
    public class FactorMainsApiController : ApiController
    {
        private SalinoContext db = new SalinoContext();

        // GET: api/FactorMainsApi
 
        public IQueryable<FactorMain> GetFactorMains()
        {
            return db.FactorMains;
        }

        // GET: api/FactorMainsApi/5
        [ResponseType(typeof(FactorMain))]
        public IHttpActionResult GetFactorMain(int id)
        {
            FactorMain factorMain = db.FactorMains.Find(id);
            if (factorMain == null)
            {
                return NotFound();
            }

            return Ok(factorMain);
        }

        // PUT: api/FactorMainsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFactorMain(int id, FactorMain factorMain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != factorMain.Id)
            {
                return BadRequest();
            }

            db.Entry(factorMain).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactorMainExists(id))
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

        // POST: api/FactorMainsApi
        [ResponseType(typeof(FactorMain))]
        public IHttpActionResult PostFactorMain(FactorMain factorMain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FactorMains.Add(factorMain);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = factorMain.Id }, factorMain);
        }

        // DELETE: api/FactorMainsApi/5
        [ResponseType(typeof(FactorMain))]
        public IHttpActionResult DeleteFactorMain(int id)
        {
            FactorMain factorMain = db.FactorMains.Find(id);
            if (factorMain == null)
            {
                return NotFound();
            }

            db.FactorMains.Remove(factorMain);
            db.SaveChanges();

            return Ok(factorMain);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FactorMainExists(int id)
        {
            return db.FactorMains.Count(e => e.Id == id) > 0;
        }
    }
}