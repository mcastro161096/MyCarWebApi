using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    public class PessoaContato
    {
        public int IdContato { get; set; }

        public int PessoaId { get; set; }
        [JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }

        public string TipoContato { get; set; }

        public string Contato { get; set; }

        [JsonIgnore]
        public DateTime Dataatualizacao { get; set; } = DateTime.Now;

    }
}