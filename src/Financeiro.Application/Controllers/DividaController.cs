using System;
using System.Net;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Exceptions;
using Financeiro.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Application.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class DividaController : ApiControllerBase
    {
        private IDividaService _service;

        public DividaController(IDividaService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("{id}", Name = "GetById")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var divida = await _service.Get(id);
                if (divida == null)
                {
                    return NotFound();
                }

                return Ok(divida);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DividaDto pessoa)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            try
            {
                var result = await this._service.Post(pessoa);
                if (result != null)
                {
                    string url = Url.Link("GetWithId", new { id = result.Id });
                    return Created(new Uri(url), result);
                }

                return BadRequest();
            }
            catch (DuplicatedValueException d)
            {
                return Failure(d.Message);
            }
            catch (ArgumentException e)
            {
                return ServerError(e.Message);
            }
        }
    }
}
