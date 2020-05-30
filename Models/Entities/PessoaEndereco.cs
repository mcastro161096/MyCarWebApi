using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    public class PessoaEndereco
    {
        public int IdEndereco { get; set; }

        public int PessoaId { get; set; }
        [JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Logradouro { get; set; }

        public string NumeroEndereco { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }

        [JsonIgnore]
        public DateTime Dataatualizacao { get; set; } = DateTime.Now;

    }
}