﻿using System;
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
    public class MarcasController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Marcas
        public IQueryable<Marcas> GetveiculosMarcas()
        {
            return db.veiculosMarcas;
        }

        // GET: api/Marcas/5
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult GetMarcas(int id)
        {
            Marcas marcas = db.veiculosMarcas.Find(id);
            if (marcas == null)
            {
                return NotFound();
            }

            return Ok(marcas);
        }

        // PUT: api/Marcas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMarcas(int id, Marcas marcas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marcas.CodMarca)
            {
                return BadRequest();
            }

            db.Entry(marcas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcasExists(id))
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

        // POST: api/Marcas
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult PostMarcas(Marcas marcas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.veiculosMarcas.Add(marcas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = marcas.CodMarca }, marcas);
        }

        // DELETE: api/Marcas/5
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult DeleteMarcas(int id)
        {
            Marcas marcas = db.veiculosMarcas.Find(id);
            if (marcas == null)
            {
                return NotFound();
            }

            db.veiculosMarcas.Remove(marcas);
            db.SaveChanges();

            return Ok(marcas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcasExists(int id)
        {
            return db.veiculosMarcas.Count(e => e.CodMarca == id) > 0;
        }
    }
}