using MyCarWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCarWebApi.Models
{
    public class PessoaDocumento
    {
        public int IdDocumento { get; set; }

        public int PessoaId { get; set; }

        [JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public DateTime DataNascimento { get; set; }

        [JsonIgnore]
        public DateTime Dataatualizacao { get; set; } = DateTime.Now;


    }
}