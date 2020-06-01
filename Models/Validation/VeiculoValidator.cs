using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    public class VeiculoValidator : AbstractValidator<Veiculo>
    {
        public VeiculoValidator()
        {
            RuleFor(v => v.TipoDeVeiculo).NotEmpty().WithMessage("O campo tipo de veículo deve ser preenchido.")
                .Length(4, 11).WithMessage("O tipo de veículo deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
            RuleFor(v => v.Marca).NotEmpty().WithMessage("O campo marca deve ser preenchido.")
                .Length(1, 20).WithMessage("A marca deve ter no mínimo {minLength} e no máximo {maxLength} caracteres. ");
            RuleFor(v => v.Modelo).NotEmpty().WithMessage("O campo modelo  deve ser preenchido")
                .Length(1, 20).WithMessage("O modelo deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
            RuleFor(v => v.Serie).Length(1, 20).WithMessage("A serie deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");

            RuleFor(v => v.Ano).NotEmpty().WithMessage("O campo ano  deve ser preenchido")
                .Length(4, 4).WithMessage("O ano deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
            RuleFor(v => v.Cor).NotEmpty().WithMessage("O campo cor  deve ser preenchido")
                .Length(1, 20).WithMessage("A cor deve ter no mínimo {minLength} e no máximo {maxLength} caracteres.");
        }

    }
}         moto carro caminhão caminhonete motocicleta