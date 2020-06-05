using FluentValidation;
using MyCarWebApi.Utils.Messages;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCarWebApi.Models
{
    public class ServicoPrestadoValidator : AbstractValidator<ServicoPrestado>
    {
        private MsgValidacao Msg = new MsgValidacao();
        public ServicoPrestadoValidator()
        {
            RuleFor(s => s.ServicoInformado).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Serviço Informado"))
                .Length(1, 50).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Serviço Informado"));

            RuleFor(s => s.DescricaoAdicionalServico).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Descrição Adicional"))
                .Length(0, 2000).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Descrição adicional"));

            RuleFor(s => s.ValorTotal).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Valor Total"));

            RuleFor(s => s.ValorPago).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Valor Pago"));

            RuleFor(s => s.Situacao).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Situação"))
                .Length(1, 10).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Situação"));

            RuleFor(s => s.DataServico).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Data Serviço"));

            RuleFor(s => s.Ativo).NotNull().WithMessage(Msg.MsgBooleanoNaoPodeSerNulo("Ativo"));

        }

    }
}
