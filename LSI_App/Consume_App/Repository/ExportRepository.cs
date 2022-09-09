using Consume_App.Repository.IRepository;
using Consume_App.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Consume_App.Repository
{
    public class ExportRepository : IExportRepository
    {
        private readonly IHttpClientFactory _clientfactory;
        public ExportRepository(IHttpClientFactory clientFactory)
        {
            _clientfactory = clientFactory;
        }


        public async Task<List<VmExport>> GetExports(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = _clientfactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<VmExport>>(jsonString);
            }
            else
            {
                return null;
            }
        }
    }
}
