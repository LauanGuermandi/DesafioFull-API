using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Financeiro.Domain.Entities;
using System;
using Financeiro.Domain.Dtos.PessoaDtos;

namespace Financeiro.Application.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        public BadRequestObjectResult Failure(string message)
        {
            return BadRequest(makeErrorContent(message));
        }

        public ObjectResult ServerError(string message)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, makeErrorContent(message));
        }

        private object makeErrorContent (string message) {
            return new { errors = new[] { message } };
        }
    }
}
