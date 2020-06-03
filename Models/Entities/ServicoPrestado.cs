using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCarWebApi.Models
{
   
    public class ServicoPrestado
    {
       
        public int Id { get; set; }

      
        public int VeiculoId { get; set; }

        [JsonIgnore]
        public virtual Veiculo Veiculo { get; set; }

       /*O campo ServicoInformado é um serviço padrão que deve ser pré cadastrado no cadastro de serviços*/
        public string ServicoInformado { get; set; }

       
        public string DescricaoAdicionalServico { get; set; }

       
        public decimal ValorTotal { get; set; }

       
        public decimal ValorPago { get; set; }

        public decimal Saldo { get; set; }

        public string Situacao { get; set; }

        public DateTime DataServico { get; set; }


        public bool Ativo { get; set; } = true;

        [JsonIgnore]
        public DateTime Dataatualizacao { get; set; } = DateTime.Now;


    }
}
