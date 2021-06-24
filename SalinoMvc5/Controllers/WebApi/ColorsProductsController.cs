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

namespace SalinoMvc5.Controllers.WebApi
{
    public class ColorsProductsController : ApiController
    {
        private SalinoContext db = new SalinoContext();

        // GET: api/ColorsProducts
        public IQueryable<ColorsProduct> GetColorsProducts()
        {
            return db.ColorsProducts;
        }

        // GET: api/ColorsProducts/5
        [ResponseType(typeof(ColorsProduct))]
        public IHttpActionResult GetColorsProduct(int ProductId)
        {
            var colorsProduct = db.ColorsProducts.Where(x => x.ProductId == ProductId).ToList();
            List<string> color = new List<string>();
            foreach (var item in colorsProduct)
            {
                var colorname = db.Colors.Find(item.ColorId).color;
                color.Add(colorname);
            }
            var colors = color;
            if (colorsProduct == null)
            {
                return NotFound();
            }

            return Ok(colors);
        }

        // PUT: api/ColorsProducts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutColorsProduct(int id, ColorsProduct colorsProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != colorsProduct.Id)
            {
                return BadRequest();
            }

            db.Entry(colorsProduct).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColorsProductExists(id))
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

        // POST: api/ColorsProducts
        [ResponseType(typeof(ColorsProduct))]
        public IHttpActionResult PostColorsProduct(ColorsProduct colorsProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ColorsProducts.Add(colorsProduct);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = colorsProduct.Id }, colorsProduct);
        }

        // DELETE: api/ColorsProducts/5
        [ResponseType(typeof(ColorsProduct))]
        public IHttpActionResult DeleteColorsProduct(int id)
        {
            ColorsProduct colorsProduct = db.ColorsProducts.Find(id);
            if (colorsProduct == null)
            {
                return NotFound();
            }

            db.ColorsProducts.Remove(colorsProduct);
            db.SaveChanges();

            return Ok(colorsProduct);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ColorsProductExists(int id)
        {
            return db.ColorsProducts.Count(e => e.Id == id) > 0;
        }
    }
}