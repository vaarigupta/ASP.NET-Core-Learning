using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Ocelot.Configuration;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
            //var one = await responses[0].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var res = new Dictionary<string, object>();
            foreach (var response in responses)
            {
                if (response.Items.DownstreamResponse() != null)
                {
                    var contentEncoding = response.Items.DownstreamResponse().Content.Headers.ContentEncoding;
                    if (contentEncoding.Contains("gzip"))
                    {
                        Stream responseStream = await response.Items.DownstreamResponse().Content.ReadAsStreamAsync();
                        responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                        StreamReader Reader = new StreamReader(responseStream, Encoding.Default);

                        string result = Reader.ReadToEnd();

                        string downStreamRouteKey = ((DownstreamRoute)response.Items["DownstreamRoute"]).Key;
                        res.Add(downStreamRouteKey, result);
                        responseStream.Close();
                    }
                }

            }
            var jsonString = JsonConvert.SerializeObject(res);
            var stringContent = new StringContent(jsonString)
            {
                Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
            };

            return new DownstreamResponse(stringContent, HttpStatusCode.OK, new List<KeyValuePair<string, IEnumerable<string>>>(), "OK");

        }
    }
}