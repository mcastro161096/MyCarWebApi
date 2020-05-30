using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCarWebApi
{
    public class ServicoPrestadoValidator : AbstractValidator<ServicoPrestado>
    {
        public ServicoPrestadoValidator()
        {

        }

    }
}
