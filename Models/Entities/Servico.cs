using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    [Table("TiposDeServico")]
    public class Servico
    {
        [Key]
        public int IdTipoServico { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descrição do Serviço")]
        public string DescricaoServico { get; set; }


        [Required]
        [Display(Name = "Valor")]
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal Valor { get; set; }

    }
}