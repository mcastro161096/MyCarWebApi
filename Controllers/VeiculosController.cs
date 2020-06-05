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
using FluentValidation;
using MyCarWebApi.Models;

namespace MyCarWebApi.Controllers
{
    public class VeiculosController : ApiController
    {
        private WebApiContext db = new WebApiContext();
        private VeiculoValidator validadorVeiculo = new VeiculoValidator();


        // GET: api/Veiculos
        public IQueryable<Veiculo> GetVeiculos()
        {
            return db.Veiculos;
        }

        // GET: api/Veiculos/5
        [ResponseType(typeof(Veiculo))]
        public IHttpActionResult GetVeiculo(int id)
        {
            Veiculo veiculo = db.Veiculos.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(veiculo);
        }

        // PUT: api/Veiculos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVeiculo(int id, Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculo.Id)
            {
                return BadRequest();
            }
            validadorVeiculo.ValidateAndThrow(veiculo);


            db.Entry(veiculo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(id))
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
        [ResponseType(typeof(Veiculo))]
        public IHttpActionResult PostVeiculo(Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            validadorVeiculo.ValidateAndThrow(veiculo);

            db.Veiculos.Add(veiculo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = veiculo.Id }, veiculo);
        }

        // DELETE: api/Veiculos/5
        [ResponseType(typeof(Veiculo))]
        public IHttpActionResult DeleteVeiculo(int id)
        {
            Veiculo veiculo = db.Veiculos.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            db.Veiculos.Remove(veiculo);
            db.SaveChanges();

            return Ok(veiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculoExists(int id)
        {
            return db.Veiculos.Count(e => e.Id == id) > 0;
        }
    }
}