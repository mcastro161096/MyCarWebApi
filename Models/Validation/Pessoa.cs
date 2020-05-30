using MyCarWebApi.Models;
using MyCarWebApi.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace MyCarWebApi
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Selecione o tipo.")]
        [MaxLength(8)]
        public TipoDePessoa Tipo { get; set; }

        public bool Ativo { get; set; }

        [Remote("ValidarCPF", "Pessoas", ErrorMessage = "Esse CPF já foi cadastrado.")]
        [Display(Name = "CPF")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Remote("ValidarCNPJ", "Pessoas", ErrorMessage = "Esse CNPJ já foi cadastrado.")]
        [Display(Name = "CNPJ")]
        [MaxLength(14)]
        public string Cnpj { get; set; }


        [MaxLength(9)]
        public Sexo Sexo { get; set; }

        [Display(Name = "Estado Civíl")]
        [MaxLength(10)]
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Preencha a data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Tipo de Contato")]
        [MaxLength(8)]
        public TipoDeContato TipoContato { get; set; }

        [MaxLength(100)]
        public string Contato { get; set; }

        [RegularExpression("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)", ErrorMessage = "Informe um estado válido.")]
        [MaxLength(25)]
        public string Estado { get; set; }

        [MaxLength(40, ErrorMessage = "O nome da cidade deve ter até {1} caracteres.")]
        public string Cidade { get; set; }

        [MaxLength(100, ErrorMessage = "O logradouro deve ter até {1} caracteres.")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        [MaxLength(6)]
        public string NumeroEndereco { get; set; }

        [MaxLength(10)]
        public string Cep { get; set; }

        [MaxLength(40, ErrorMessage = "O complemento deve ter até {1} caracteres.")]
        public string Complemento { get; set; }


        [Display(Name = "Selecione a função da pessoa")]
        public Papel Papel { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }


        public DateTime Dataatualizacao { get; set; }

       
       



    }
}
