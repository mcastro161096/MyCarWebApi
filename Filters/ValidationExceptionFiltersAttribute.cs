using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace MyCarWebApi.Filters
{
    public class ValidationExceptionFiltersAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
           if (actionExecutedContext.Exception is ValidationException)
            {
                var resultadovalidacao = new ResultadoValidacao("Ocorreram erros de validação nessa requisição. Verifique a lista de erros.");
                (actionExecutedContext.Exception as ValidationException).Errors.
                                                                         ToList().
                                                                         ForEach(e => resultadovalidacao.AdicionarErro(e.PropertyName, e.ErrorMessage));

                var resposta = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new System.Net.Http.ObjectContent<ResultadoValidacao>(
                        resultadovalidacao, new System.Net.Http.Formatting.JsonMediaTypeFormatter())
                };
            actionExecutedContext.Response = resposta;
            }
        }
    }
}