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
    public class AcoesController : ControllerBase
    {
        private readonly IAcoesService _service;

        public AcoesController(IAcoesService service)
        {
            _service = service;
        }

        // GET: api/<AcoesController>
        [HttpGet]
        public async Task<IEnumerable<Acoes>> Get()
        {
            var obj = await _service.List();

            return obj;
        }

        // GET api/<AcoesController>/5
        [HttpGet("{id}")]
        public async Task<Acoes> Get(string id)
        {
            var obj = await _service.GetEntityById(id);


            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://api-cotacao-b3.labdo.it"),
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync($"api/cotacao/cd_acao/{obj.CodigoAcao}");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<CotacaoAPIDto>>(content);

            var valorAcao = result.FirstOrDefault().vl_fechamento;




            return obj;
        }

        [HttpGet()]
        [Route("cotacao/{id}")]
        public async Task<CotacaoDto> CotacaoGet(string id)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://api-cotacao-b3.labdo.it"),
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync($"api/cotacao/cd_acao/{id}");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<CotacaoAPIDto>>(content);

            var acao = result.FirstOrDefault();

            var obj = new CotacaoDto();

            obj.CodigoAcao = id;
            obj.RazaoSocial = acao.nm_empresa_rdz;
            obj.Valor = acao.vl_fechamento;


            return obj;
        }

        // POST api/<AcoesController>
        [HttpPost]
        public async void Post(Acoes value)
        {

            var obj = new Acoes();

            obj = value;
            await _service.Add(obj);


        }

        // PUT api/<AcoesController>/5
        [HttpPut("{id}")]
        public async void Put(string id, Acoes value)
        {
            var obj = await _service.GetEntityById(id);

            if (obj != null)
            {

                obj.CodigoAcao = id;
                obj.RazaoSocial = value.RazaoSocial;

                await _service.Update(obj);

            }
        }

        // DELETE api/<AcoesController>/5
        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            await _service.Delete(id);

        }
    }
}
