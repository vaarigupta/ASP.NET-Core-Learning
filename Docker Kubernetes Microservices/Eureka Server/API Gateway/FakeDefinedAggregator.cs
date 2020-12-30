using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace API_Gateway
{
    internal class FakeDefinedAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {

            //var responseBodies = responses.Select(response =>
            //{
            //    //_logger.LogDebug($"Status code {response.Response.StatusCode}.");

            //    using var responseReader = new StreamReader(response.Response.Body);
            //    return responseReader.ReadToEnd();
            //}).ToList();

            //return new DownstreamResponse(
            //    new StringContent(JsonConvert.SerializeObject(responseBodies)),
            //    HttpStatusCode.OK,
            //    new List<Header>(),
            //    "OK");

            var contentBuilder = new StringBuilder();
            contentBuilder.Append(responses);

            var stringContent = new StringContent(contentBuilder.ToString())
            {
                Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
            };

            return new DownstreamResponse(stringContent, HttpStatusCode.OK, new List<KeyValuePair<string, IEnumerable<string>>>(), "OK");

        }

    }
}