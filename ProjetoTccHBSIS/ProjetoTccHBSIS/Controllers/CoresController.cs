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
        private ProjetoTccHBSISContext db = new ProjetoTccHBSISContext();

        // GET: api/Cores
        public IQueryable<VeiculosCores> GetCores()
        {
            return db.Cores;
        }

        // GET: api/Cores/5
        [ResponseType(typeof(VeiculosCores))]
        public IHttpActionResult GetCores(int id)
        {
            VeiculosCores cores = db.Cores.Find(id);
            if (cores == null)
            {
                return NotFound();
            }

            return Ok(cores);
        }

        // PUT: api/Cores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCores(int id, VeiculosCores cores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cores.Id)
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
        [ResponseType(typeof(VeiculosCores))]
        public IHttpActionResult PostCores(VeiculosCores cores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cores.Add(cores);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cores.Id }, cores);
        }

        // DELETE: api/Cores/5
        [ResponseType(typeof(VeiculosCores))]
        public IHttpActionResult DeleteCores(int id)
        {
            VeiculosCores cores = db.Cores.Find(id);
            if (cores == null)
            {
                return NotFound();
            }

            db.Cores.Remove(cores);
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
            return db.Cores.Count(e => e.Id == id) > 0;
        }
    }
}