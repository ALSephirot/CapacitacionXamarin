using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Capacitacion.Services
{
    class ApiService
    {
        HttpClient client;

        public ApiService()
        {
            client = new HttpClient();
        }

        public async Task<T> GetData<T>(string url)
        {
            var uri = new Uri(url);

            using (client)
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var result = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
    }
}
