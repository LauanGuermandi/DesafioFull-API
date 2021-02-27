using System.ComponentModel.DataAnnotations;
using System;
using System.Net;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.PessoaDtos;
using Financeiro.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Financeiro.Domain.Exceptions;

namespace Financeiro.Application.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var pessoas = await _service.GetAll();
                if (pessoas == null)
                {
                    return NotFound();
                }

                return Ok(pessoas);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetPessoaById")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var pessoa = await _service.Get(id);
                if (pessoa == null)
                {
                    return NotFound();
                }

                return Ok(pessoa);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PessoaCreateDto pessoa)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await this._service.Post(pessoa);
                if (result != null)
                {
                    string url = Url.Link("GetPessoaById", new { id = result.Id });
                    return Created(new Uri(url), result);
                }

                return BadRequest();
            }
            catch (DuplicatedValueException d)
            {
                return BadRequest(d.Message);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
