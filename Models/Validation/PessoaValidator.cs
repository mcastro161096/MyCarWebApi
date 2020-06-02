using FluentValidation;
using MyCarWebApi.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MyCarWebApi.Models
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O campo nome  deve ser preenchido.")
            .Length(1, 100).WithMessage(" O nome  deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
            
            RuleFor(p => p.Sobrenome).NotEmpty().WithMessage("O campo sobrenome  deve ser preenchido.")
                .Length(1, 100).WithMessage(" O sobrenome deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
           
            RuleFor(p => p.Tipo).NotEmpty().WithMessage("O campo tipo deve ser preenchido.")
                .Length(1, 8).WithMessage(" O tipo deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
           
            RuleFor(p => p.Cpf).Length(0, 11).WithMessage(" O cpf deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
           
            RuleFor(p => p.Cnpj).Length(0, 14).WithMessage(" O cnpj deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
            
            RuleFor(p => p.Sexo).NotEmpty().WithMessage("O campo sexo deve ser preenchido.")
                .Length(6, 9).WithMessage(" O sexo deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.EstadoCivil).Length(0, 10).WithMessage(" O estado civil deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.DataNascimento).NotEmpty().WithMessage("O campo data de nascimento deve ser preenchido.");

            RuleFor(p => p.Estado).NotEmpty().WithMessage("O campo estado deve ser preenchido.")
                .Length(1, 25).WithMessage(" O estado deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Cidade).NotEmpty().WithMessage("O campo  deve ser preenchido.")
                .Length(1, 50).WithMessage("A cidade deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Logradouro).NotEmpty().WithMessage("O campo logradouro deve ser preenchido.")
                .Length(1, 100).WithMessage("O logradouro deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.NumeroEndereco).NotEmpty().WithMessage("O campo numero endereço  deve ser preenchido.")
                .Length(8, 8).WithMessage("O numero endereço deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Cep).Length(1, 10).WithMessage("O  deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Complemento).Length(0, 50).WithMessage("O  deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Papel).NotEmpty().WithMessage("O campo papel deve ser preenchido.")
                .Length(1, 13).WithMessage("O papel deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Login).NotEmpty().WithMessage("O campo login deve ser preenchido.")
                .Length(3, 50).WithMessage("O login deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(p => p.Senha).NotEmpty().WithMessage("O campo senha deve ser preenchido.")
                .Length(3, 50).WithMessage("A senha deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");


        }
    }
}
