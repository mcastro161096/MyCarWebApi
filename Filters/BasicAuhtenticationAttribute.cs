﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MyCarWebApi.Filters
{
    public class BasicAuhtenticationAttribute : AuthorizationFilterAttribute
    {
        private const string TOKEN = "teste";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authorizationHeader =  actionContext.Request.Headers.Authorization;
            if (authorizationHeader == null || authorizationHeader.Scheme != "Bearer" || authorizationHeader.Parameter != TOKEN)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
        }
    }
}