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
    builder.EntitySet<Pessoa>("Pessoas");
    builder.EntitySet<Veiculo>("Veiculos"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PessoasController : ODataController
    {
        private WebApiContext db = new WebApiContext();

        // GET: odata/Pessoas
        [EnableQuery]
        public IQueryable<Pessoa> GetPessoas()
        {
            return db.Pessoas;
        }

        // GET: odata/Pessoas(5)
        [EnableQuery]
        public SingleResult<Pessoa> GetPessoa([FromODataUri] int key)
        {
            return SingleResult.Create(db.Pessoas.Where(pessoa => pessoa.Id == key));
        }

        // PUT: odata/Pessoas(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Pessoa> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pessoa pessoa = await db.Pessoas.FindAsync(key);
            if (pessoa == null)
            {
                return NotFound();
            }

            patch.Put(pessoa);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pessoa);
        }

        // POST: odata/Pessoas
        public async Task<IHttpActionResult> Post(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pessoas.Add(pessoa);
            await db.SaveChangesAsync();

            return Created(pessoa);
        }

        // PATCH: odata/Pessoas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Pessoa> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pessoa pessoa = await db.Pessoas.FindAsync(key);
            if (pessoa == null)
            {
                return NotFound();
            }

            patch.Patch(pessoa);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pessoa);
        }

        // DELETE: odata/Pessoas(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            Pessoa pessoa = await db.Pessoas.FindAsync(key);
            if (pessoa == null)
            {
                return NotFound();
            }

            db.Pessoas.Remove(pessoa);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Pessoas(5)/Veiculos
        [EnableQuery]
        public IQueryable<Veiculo> GetVeiculos([FromODataUri] int key)
        {
            return db.Pessoas.Where(m => m.Id == key).SelectMany(m => m.Veiculos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PessoaExists(int key)
        {
            return db.Pessoas.Count(e => e.Id == key) > 0;
        }
    }
}
