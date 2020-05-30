using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCarWebApi
{[Table("ServicosPrestados")]
    public class ServicoPrestado
    {
        [Key]
        public int IdServico { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        [MaxLength(50)]
        [Display(Name = "Informe o serviço:")]
        public string ServicoInformado { get; set; }

        [MaxLength(2000)]
        [Display(Name = "Descrição adicional do serviço")]
        public string DescricaoAdicionalServico { get; set; }

        [Display(Name = "Valor Total")]
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal ValorTotal { get; set; }

        [Display(Name = "Valor Pago")]
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal ValorPago { get; set; }

        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal Saldo { get; set; }

        [MaxLength(8)]
        public string Pago { get; set; }

        [Display(Name = "Data do Serviço")]
        public DateTime DataServico { get; set; }

       

        public bool Ativo { get; set; }


        public DateTime Dataatualizacao { get; set; }


    }
}
