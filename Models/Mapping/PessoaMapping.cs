using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Web.Mvc;

namespace MyCarWebApi.Models
{
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapping()
        {
            ToTable("Pessoas");
            HasKey(m => m.Id);

            Property(m => m.Nome).IsRequired().HasMaxLength(100);
            Property(m => m.Sobrenome).IsRequired().HasMaxLength(100);
            Property(m => m.Tipo).IsRequired().HasMaxLength(8);
            Property(m => m.Ativo).IsRequired();
            Property(m => m.Cpf).HasMaxLength(11);
            Property(m => m.Cnpj).HasMaxLength(14);
            Property(m => m.Sexo).IsRequired().HasMaxLength(9);
            Property(m => m.EstadoCivil).HasMaxLength(10);
            Property(m => m.DataNascimento).IsRequired();
            Property(m => m.Estado).IsRequired().HasMaxLength(25);
            Property(m => m.Cidade).IsRequired().HasMaxLength(50);
            Property(m => m.Logradouro).IsRequired().HasMaxLength(100);
            Property(m => m.NumeroEndereco).IsRequired().HasMaxLength(8);
            Property(m => m.Cep).HasMaxLength(10);
            Property(m => m.Complemento).HasMaxLength(50);
            Property(m => m.Papel).IsRequired().HasMaxLength(13);
            Property(m => m.Login).IsRequired().HasMaxLength(50);
            Property(m => m.Senha).IsRequired().HasMaxLength(50);
            Property(m => m.DataCadastro).IsRequired();
            Property(m => m.Dataatualizacao).IsRequired();

        }

    }
}
