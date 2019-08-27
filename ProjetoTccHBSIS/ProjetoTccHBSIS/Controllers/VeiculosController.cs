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
    public class VeiculosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Veiculos
        public IQueryable<Veiculos> Getveiculos()
        {
            return db.veiculos;
        }

        // GET: api/Veiculos/5
        [ResponseType(typeof(Veiculos))]
        public IHttpActionResult GetVeiculos(int id)
        {
            Veiculos veiculos = db.veiculos.Find(id);
            if (veiculos == null)
            {
                return NotFound();
            }

            return Ok(veiculos);
        }

        // PUT: api/Veiculos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVeiculos(int id, Veiculos veiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculos.Id)
            {
                return BadRequest();
            }

            db.Entry(veiculos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculosExists(id))
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

        // POST: api/Veiculos
        [ResponseType(typeof(Veiculos))]
        public IHttpActionResult PostVeiculos(Veiculos veiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.veiculos.Add(veiculos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = veiculos.Id }, veiculos);
        }

        // DELETE: api/Veiculos/5
        [ResponseType(typeof(Veiculos))]
        public IHttpActionResult DeleteVeiculos(int id)
        {
            Veiculos veiculos = db.veiculos.Find(id);
            if (veiculos == null)
            {
                return NotFound();
            }

            db.veiculos.Remove(veiculos);
            db.SaveChanges();

            return Ok(veiculos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculosExists(int id)
        {
            return db.veiculos.Count(e => e.Id == id) > 0;
        }
    }
}