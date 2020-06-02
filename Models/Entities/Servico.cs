using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCarWebApi.Models
{
    
    public class Servico
    {
       
        public int IdTipoServico { get; set; }

       
        public string DescricaoServico { get; set; }


       
        public decimal Valor { get; set; }

    }
}