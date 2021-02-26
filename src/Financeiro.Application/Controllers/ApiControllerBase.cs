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
            return BadRequest(new { error = message });
        }

        public ObjectResult ServerError(string message)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, new { error = message });
        }

        public OkObjectResult Success([ActionResultObjectValue] object value)
        {
            return Ok(value);
        }

        public Uri makeUri(PessoaDto entity, string routeName = null)
        {
            routeName = String.IsNullOrEmpty(routeName) ? "GetById" : routeName;
            return new Uri(Url.Link(routeName, new { id = entity.Id }));
        }
    }
}
