using MyCarWebApi.Models;
using MyCarWebApi.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace MyCarWebApi
{
    
    public class Pessoa
    {
        public int IdPessoa { get; set; }
   
        public string Nome { get; set; }
 
        public string Sobrenome { get; set; }
    
        public TipoDePessoa Tipo { get; set; }

        public bool Ativo { get; set; }

        public string Cpf { get; set; }
  
        public string Cnpj { get; set; }

        public Sexo Sexo { get; set; }
  
        public EstadoCivil EstadoCivil { get; set; }

        public DateTime DataNascimento { get; set; }

        public TipoDeContato TipoContato { get; set; }

        public string Contato { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Logradouro { get; set; }

        public string NumeroEndereco { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }

        public Papel Papel { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public DateTime Dataatualizacao { get; set; } = DateTime.Now;






    }
}
