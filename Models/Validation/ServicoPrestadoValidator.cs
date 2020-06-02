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

        }

    }
}
