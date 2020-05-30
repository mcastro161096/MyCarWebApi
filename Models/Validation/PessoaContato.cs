using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    [Table("PessoaContatos")]
    public class PessoaContato
    {
        [Key]
        public int IdContato { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        [Display(Name = "Tipo de Contato")]
        [MaxLength(8)]
        public TipoDeContato TipoContato { get; set; }

        [MaxLength(100)]
        public string Contato { get; set; }

        public DateTime Dataatualizacao { get; set; }

    }
}