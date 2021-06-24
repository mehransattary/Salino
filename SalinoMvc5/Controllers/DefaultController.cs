using Salino.DataLayer;
using Salino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalinoMvc5.Controllers
{
    public class DefaultController : ApiController
    {
        public DefaultController()
        {
            // Add the following code
            // problem will be solved
            db.Configuration.ProxyCreationEnabled = false;
        }
        private SalinoContext db = new SalinoContext();
        // GET: api/Default
        public IEnumerable<Product> Get()
        {
            return db.Products.ToList();
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
