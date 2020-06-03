using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCarWebApi.Models
{
    public class ServicoPrestadoValidator : AbstractValidator<ServicoPrestado>
    {
        public ServicoPrestadoValidator()
        {
            RuleFor(s => s.ServicoInformado).NotEmpty().WithMessage("O campo  deve ser preenchido.")
                .Length(1, 50).WithMessage("O serviço informado deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(s => s.DescricaoAdicionalServico).NotEmpty().WithMessage("O campo  deve ser preenchido.")
                .Length(0, 2000).WithMessage("A descrição deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(s => s.ValorTotal).NotEmpty().WithMessage("O campo valor total  deve ser preenchido.");

            RuleFor(s => s.ValorPago).NotEmpty().WithMessage("O campo valor pago deve ser preenchido.");

            RuleFor(s => s.Situacao).NotEmpty().WithMessage("O campo situação deve ser preenchido.")
                .Length(1, 10).WithMessage("A situação deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(s => s.DataServico).NotEmpty().WithMessage("O campo data do serviço deve ser preenchido.");


        }

    }
}
