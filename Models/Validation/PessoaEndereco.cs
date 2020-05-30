using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    [Table("PessoaEndereco")]
    public class PessoaEndereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [RegularExpression("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)", ErrorMessage = "Informe um estado válido.")]
        [MaxLength(25)]
        public string Estado { get; set; }

        [MaxLength(40, ErrorMessage = "O nome da cidade deve ter até {1} caracteres.")]
        public string Cidade { get; set; }

        [MaxLength(100, ErrorMessage = "O logradouro deve ter até {1} caracteres.")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        [MaxLength(6)]
        public string NumeroEndereco { get; set; }

        [MaxLength(10)]
        public string Cep { get; set; }

        [MaxLength(40, ErrorMessage = "O complemento deve ter até {1} caracteres.")]
        public string Complemento { get; set; }

        public DateTime Dataatualizacao { get; set; }

    }
}