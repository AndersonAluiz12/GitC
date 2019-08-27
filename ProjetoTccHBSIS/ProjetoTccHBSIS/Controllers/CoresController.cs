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
using ProjetoTccHBSIS.Models;

namespace ProjetoTccHBSIS.Controllers
{
    public class CoresController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Cores
        public IQueryable<Cores> GetveiculosCores()
        {
            return db.veiculosCores;
        }

        // GET: api/Cores/5
        [ResponseType(typeof(Cores))]
        public IHttpActionResult GetCores(int id)
        {
            Cores cores = db.veiculosCores.Find(id);
            if (cores == null)
            {
                return NotFound();
            }

            return Ok(cores);
        }

        // PUT: api/Cores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCores(int id, Cores cores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cores.CodCor)
            {
                return BadRequest();
            }

            db.Entry(cores).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoresExists(id))
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

        // POST: api/Cores
        [ResponseType(typeof(Cores))]
        public IHttpActionResult PostCores(Cores cores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.veiculosCores.Add(cores);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cores.CodCor }, cores);
        }

        // DELETE: api/Cores/5
        [ResponseType(typeof(Cores))]
        public IHttpActionResult DeleteCores(int id)
        {
            Cores cores = db.veiculosCores.Find(id);
            if (cores == null)
            {
                return NotFound();
            }

            db.veiculosCores.Remove(cores);
            db.SaveChanges();

            return Ok(cores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CoresExists(int id)
        {
            return db.veiculosCores.Count(e => e.CodCor == id) > 0;
        }
    }
}