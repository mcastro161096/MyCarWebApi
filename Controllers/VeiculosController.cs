using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using MyCarWebApi.Models;

namespace MyCarWebApi.Controllers
{
    /*
    A classe WebApiConfig pode requerer alterações adicionais para adicionar uma rota para esse controlador.
    Misture essas declarações no método Register da classe WebApiConfig conforme aplicável. Note que URLs OData diferenciam maiúsculas e minúsculas.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using MyCarWebApi.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Veiculo>("Veiculos");
    builder.EntitySet<Pessoa>("Pessoas"); 
    builder.EntitySet<ServicoPrestado>("ServicosPrestados"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class VeiculosController : ODataController
    {
        private WebApiContext db = new WebApiContext();

        // GET: odata/Veiculos
        [EnableQuery]
        public IQueryable<Veiculo> GetVeiculos()
        {
            return db.Veiculos;
        }

        // GET: odata/Veiculos(5)
        [EnableQuery]
        public SingleResult<Veiculo> GetVeiculo([FromODataUri] int key)
        {
            return SingleResult.Create(db.Veiculos.Where(veiculo => veiculo.Id == key));
        }

        // PUT: odata/Veiculos(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Veiculo> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Veiculo veiculo = await db.Veiculos.FindAsync(key);
            if (veiculo == null)
            {
                return NotFound();
            }

            patch.Put(veiculo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(veiculo);
        }

        // POST: odata/Veiculos
        public async Task<IHttpActionResult> Post(Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veiculos.Add(veiculo);
            await db.SaveChangesAsync();

            return Created(veiculo);
        }

        // PATCH: odata/Veiculos(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Veiculo> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Veiculo veiculo = await db.Veiculos.FindAsync(key);
            if (veiculo == null)
            {
                return NotFound();
            }

            patch.Patch(veiculo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(veiculo);
        }

        // DELETE: odata/Veiculos(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            Veiculo veiculo = await db.Veiculos.FindAsync(key);
            if (veiculo == null)
            {
                return NotFound();
            }

            db.Veiculos.Remove(veiculo);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Veiculos(5)/Pessoa
        [EnableQuery]
        public SingleResult<Pessoa> GetPessoa([FromODataUri] int key)
        {
            return SingleResult.Create(db.Veiculos.Where(m => m.Id == key).Select(m => m.Pessoa));
        }

        // GET: odata/Veiculos(5)/ServicosPrestados
        [EnableQuery]
        public IQueryable<ServicoPrestado> GetServicosPrestados([FromODataUri] int key)
        {
            return db.Veiculos.Where(m => m.Id == key).SelectMany(m => m.ServicosPrestados);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculoExists(int key)
        {
            return db.Veiculos.Count(e => e.Id == key) > 0;
        }
    }
}
