using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCarWebApi.Models
{
   
    public class ServicoPrestado
    {
       
        public int IdServico { get; set; }

      
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

       
        public string ServicoInformado { get; set; }

       
        public string DescricaoAdicionalServico { get; set; }

       
        public decimal ValorTotal { get; set; }

       
        public decimal ValorPago { get; set; }

        public decimal Saldo { get; set; }

        public string Pago { get; set; }

        public DateTime DataServico { get; set; }

       

        public bool Ativo { get; set; }


        public DateTime Dataatualizacao { get; set; }


    }
}
