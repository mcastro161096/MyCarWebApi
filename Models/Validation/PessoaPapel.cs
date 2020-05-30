using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    [Table("PessoaPapel")]
    public class PessoaPapel
    {
        [Key]
        public int IdPapel { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [Display(Name ="Selecione a função da pessoa")]
        public Papel Papel { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public DateTime Dataatualizacao { get; set; }
    }
}