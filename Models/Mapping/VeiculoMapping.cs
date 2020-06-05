using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using MyCarWebApi.Models;

namespace MyCarWebApi.Models
{
    public class VeiculoMapping : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMapping()
        {
            ToTable("Veiculos");
            HasKey(m => m.Id);
            Property(m => m.TipoDeVeiculo).IsRequired().HasMaxLength(15);
            Property(m => m.Marca).IsRequired().HasMaxLength(20);
            Property(m => m.Modelo).IsRequired().HasMaxLength(20);
            Property(m => m.Serie).HasMaxLength(20);
            Property(m => m.Ano).IsRequired().HasMaxLength(4);
            Property(m => m.Cor).IsRequired().HasMaxLength(20);
            Property(m => m.Ativo).IsRequired();
            Property(m => m.Dataatualizacao).IsRequired();


            HasRequired<Pessoa>(v => v.Pessoa).WithMany(p => p.Veiculos)
                                                .HasForeignKey(m => m.PessoaId)
                                                .WillCascadeOnDelete();
                                                
        }

    }
}