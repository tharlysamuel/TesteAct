using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TesteAct.Test
{
    public class GetAcoesTest
    {
        [Fact]
        public void Test()
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://api-cotacao-b3.labdo.it"),
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));


            Task.Run(async () =>
            {
                var response = await client.GetAsync("api/cotacao/cd_acao/BIDI11");
                var content = await response.Content.ReadAsStringAsync();

            }).ConfigureAwait(false);

            

            Assert.Equal("AFI.AX", "");


        }


    }
}
