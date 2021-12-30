using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TesteAct.Domain;
using TesteAct.Domain.Dto;
using TesteAct.Domain.Interfaces.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteAct.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroOperacoesController : ControllerBase
    {
        private readonly IRegistroOperacoesService _service;

        public RegistroOperacoesController(IRegistroOperacoesService service)
        {
            _service = service;
        }

        // GET: api/<RegistroOperacoesController>
        [HttpGet]
        public async Task<IEnumerable<RegistroOperacoes>> Get()
        {
            var obj = await _service.List();

            return obj;
        }

        // GET api/<RegistroOperacoesController>/5
        [HttpGet("{id}")]
        public async Task<List<RegistroOperacoes>> Get(string id)
        {
            var obj = await _service.GetEntityByAcao(id);
         
            return obj;
        }

        // POST api/<RegistroOperacoesController>
        [HttpPost]
        public async void Post(RegistroOperacoes value)
        {

            var obj = new RegistroOperacoes();

            obj = value;

            var valorTotal = obj.ValorAcao * obj.Quantidade;

            decimal percentual = 0.0325M / 100;
            decimal taxa = 5.00M;

            decimal custoOperacao = taxa + (percentual * obj.ValorAcao);

            obj.ValorTotal = valorTotal + custoOperacao;
            await _service.Add(obj);

        }

        // PUT api/<RegistroOperacoesController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, RegistroOperacoes value)
        {
            var obj = await _service.GetEntityById(id);

            if (obj != null)
            {

                await _service.Update(value);

            }
        }

        // DELETE api/<RegistroOperacoesController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _service.Delete(id);

        }
    }
}
