using MyCarWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCarWebApi.Models
{
    [Table("PessoaDocumentos")]
    public class PessoaDocumento
    {
        [Key]
        public int IdDocumento { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        [Remote("ValidarCPF", "Pessoas", ErrorMessage = "Esse CPF já foi cadastrado.")]
        [Display(Name = "CPF")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Remote("ValidarCNPJ", "Pessoas", ErrorMessage = "Esse CNPJ já foi cadastrado.")]
        [Display(Name = "CNPJ")]
        [MaxLength(14)]
        public string Cnpj { get; set; }


        [MaxLength(9)]
        public Sexo Sexo { get; set; }

        [Display(Name = "Estado Civíl")]
        [MaxLength(10)]
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Preencha a data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public DateTime Dataatualizacao { get; set; }


    }
}