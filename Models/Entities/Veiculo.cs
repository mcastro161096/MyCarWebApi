using Newtonsoft.Json;
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
       
        public int Id { get; set; }

       
        public int PessoaId { get; set; }
        [JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }

        public string TipoDeVeiculo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Serie { get; set; }

        public string Ano { get; set; }

        public string Cor { get; set; }

        public bool Ativo { get; set; }
        
        public DateTime Dataatualizacao { get; set; }

    }
}