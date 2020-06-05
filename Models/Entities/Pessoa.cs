using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace MyCarWebApi.Models
{

    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Tipo { get; set; }

        public bool Ativo { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Logradouro { get; set; }

        public string NumeroEndereco { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }

        public string Papel { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; } 
        [JsonIgnore]
        public DateTime Dataatualizacao { get; private set; } = DateTime.Now;
        
        public virtual ICollection<Veiculo> Veiculos { get; set; }



    }
}
