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

            RuleFor(s => s.DescricaoAdicionalServico).NotEmpty().WithMessage("O campo  deve ser preenchido.");

            RuleFor(s => s.).NotEmpty().WithMessage("O campo  deve ser preenchido.");

            RuleFor(s => s.).NotEmpty().WithMessage("O campo  deve ser preenchido.");

            RuleFor(s => s.).NotEmpty().WithMessage("O campo  deve ser preenchido.");

            RuleFor(s => s.).NotEmpty().WithMessage("O campo  deve ser preenchido.");

            RuleFor(s => s.).NotEmpty().WithMessage("O campo  deve ser preenchido.");

            RuleFor(s => s.).NotEmpty().WithMessage("O campo  deve ser preenchido.");
        }

    }
}
