using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyCarWebApi.Models
{ 
    public class ServicoPrestadoMapping : EntityTypeConfiguration<ServicoPrestado>
    {
        public ServicoPrestadoMapping()
        {
            ToTable("ServicosPrestados");
            HasKey(s => s.Id);

            Property(s => s.ServicoInformado).IsRequired().HasMaxLength(50);
            Property(s => s.DescricaoAdicionalServico).HasMaxLength(2000);
            Property(s => s.ValorTotal).IsRequired();
            Property(s => s.ValorPago).IsRequired();
            Property(s => s.Saldo).IsRequired();
            Property(s => s.Situacao).IsRequired().HasMaxLength(10);
            Property(s => s.DataServico).IsRequired();
            Property(s => s.Ativo).IsRequired();
            Property(s => s.Dataatualizacao).IsRequired();

            HasRequired<Veiculo>(s => s.Veiculo).WithMany(v => v.ServicosPrestados)
                                                          .HasForeignKey(s => s.VeiculoId)
                                                          .WillCascadeOnDelete();




        }

    }
}
