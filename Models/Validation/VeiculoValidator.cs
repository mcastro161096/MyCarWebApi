using FluentValidation;
using MyCarWebApi.Utils.Messages;
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
        private MsgValidacao Msg = new MsgValidacao();
        public VeiculoValidator()
        {
            RuleFor(v => v.TipoDeVeiculo).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Tipo de veículo"))
                .Length(4, 11).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Tipo de veículo"));

            RuleFor(v => v.Marca).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Marca"))
                .Length(1, 20).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Marca"));

            RuleFor(v => v.Modelo).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Modelo"))
                .Length(1, 20).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Modelo"));

            RuleFor(v => v.Serie).Length(0, 20).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Serie"));

            RuleFor(v => v.Ano).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Ano"))
                .Length(4, 4).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Ano"));

            RuleFor(v => v.Cor).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Cor"))
                .Length(1, 20).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Cor"));

            RuleFor(v => v.Ativo).NotNull().WithMessage(Msg.MsgBooleanoNaoPodeSerNulo("Ativo"));
        }

    }
}        
//moto carro caminhão caminhonete motocicleta