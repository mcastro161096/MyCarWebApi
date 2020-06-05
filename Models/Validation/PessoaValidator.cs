using FluentValidation;
using MyCarWebApi.Models;
using MyCarWebApi.Utils.Messages;
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
        private MsgValidacao Msg = new MsgValidacao();
        public PessoaValidator()
        {

            RuleFor(p => p.Nome).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Nome"))
            .Length(1, 100).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Nome"));
            
            RuleFor(p => p.Sobrenome).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Sobrenome"))
                .Length(1, 100).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Sobrenome"));
           
            RuleFor(p => p.Tipo).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Tipo"))
                .Length(1, 8).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Tipo"));
           
            RuleFor(p => p.Cpf).Length(0, 11).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("CPF"));
           
            RuleFor(p => p.Cnpj).Length(0, 14).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("CNPJ"));
            
            RuleFor(p => p.Sexo).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Sexo"))
                .Length(6, 9).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Sexo"));

            RuleFor(p => p.EstadoCivil).Length(0, 10).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Estado civíl"));

            RuleFor(p => p.DataNascimento).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("data de Nascimento"));

            RuleFor(p => p.Estado).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Estado"))
                .Length(1, 25).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Estado"));

            RuleFor(p => p.Cidade).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Cidade"))
                .Length(1, 50).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Cidade"));

            RuleFor(p => p.Logradouro).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Logradouro"))
                .Length(1, 100).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Logradouro"));

            RuleFor(p => p.NumeroEndereco).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Numero Endereço"))
                .Length(1, 8).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Numero Endereço"));

            RuleFor(p => p.Cep).Length(0, 10).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("CEP"));

            RuleFor(p => p.Complemento).Length(0, 50).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Complemento"));

            RuleFor(p => p.Papel).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Papel"))
                .Length(1, 13).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Papel"));

            RuleFor(p => p.Login).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Login"))
                .Length(3, 50).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Login"));

            RuleFor(p => p.Senha).NotEmpty().WithMessage(Msg.MsgPreencherCampoVazioObrigatorio("Senha"))
                .Length(3, 50).WithMessage(Msg.MsgTamanhoMinEMaxDoCampo("Senha"));

            RuleFor(p => p.Ativo).NotNull().WithMessage(Msg.MsgBooleanoNaoPodeSerNulo("Ativo"));



        }
    }
}
