using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "Tipo de veículo")]
        public string TipoDeVeiculo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(20)]
        public string Modelo { get; set; }

        [MaxLength(20)]
        [Display(Name = "Série")]
        public string Serie { get; set; }

        [Required]
        [MaxLength(4)]
        public string Ano { get; set; }

        [Required]
        [MaxLength(20)]
        public string Cor { get; set; }

        public bool Ativo { get; set; }
        
        public DateTime Dataatualizacao { get; set; }

    }
}