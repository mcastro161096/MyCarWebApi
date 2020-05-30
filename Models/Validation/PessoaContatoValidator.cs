using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    public class PessoaContatoValidator : AbstractValidator<PessoaContato>
    {
        public PessoaContatoValidator()
        {

        }

    }
}