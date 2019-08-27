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
using ProjetoPadawanTCC.Models;

namespace ProjetoPadawanTCC.Controllers
{
    public class TermoUsoesController : ApiController
    {
        private ProjetoPadawanTCCContext db = new ProjetoPadawanTCCContext();

        // GET: api/TermoUsoes
        public IQueryable<TermoUso> GetTermoUsoes()
        {
            return db.TermoUsoes;
        }

        // GET: api/TermoUsoes/5
        [ResponseType(typeof(TermoUso))]
        public IHttpActionResult GetTermoUso(int id)
        {
            TermoUso termoUso = db.TermoUsoes.Find(id);
            if (termoUso == null)
            {
                return NotFound();
            }

            return Ok(termoUso);
        }

        // PUT: api/TermoUsoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTermoUso(int id, TermoUso termoUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termoUso.CodidoTermoo)
            {
                return BadRequest();
            }

            db.Entry(termoUso).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermoUsoExists(id))
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

        // POST: api/TermoUsoes
        [ResponseType(typeof(TermoUso))]
        public IHttpActionResult PostTermoUso(TermoUso termoUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TermoUsoes.Add(termoUso);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = termoUso.CodidoTermoo }, termoUso);
        }

        // DELETE: api/TermoUsoes/5
        [ResponseType(typeof(TermoUso))]
        public IHttpActionResult DeleteTermoUso(int id)
        {
            TermoUso termoUso = db.TermoUsoes.Find(id);
            if (termoUso == null)
            {
                return NotFound();
            }

            db.TermoUsoes.Remove(termoUso);
            db.SaveChanges();

            return Ok(termoUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermoUsoExists(int id)
        {
            return db.TermoUsoes.Count(e => e.CodidoTermoo == id) > 0;
        }
    }
}