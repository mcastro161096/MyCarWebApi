using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarWebApi.Models
{
   public class WebApiContext : DbContext
    {
        public WebApiContext() : base("name=DbMyCarWebApi")
        {
            Database.SetInitializer<WebApiContext>(new CreateDatabaseIfNotExists<WebApiContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add<Pessoa>(new PessoaMapping());
            modelBuilder.Configurations.Add<Veiculo>(new VeiculoMapping());
            modelBuilder.Configurations.Add<ServicoPrestado>(new ServicoPrestadoMapping());
        }

        public  DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<ServicoPrestado> ServicosPrestados { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }





    }
}
