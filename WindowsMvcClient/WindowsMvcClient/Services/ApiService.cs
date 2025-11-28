using System.Net.Http;
using System.Threading.Tasks;

namespace WindowsMvcClient.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://<LinuxPublicIP>:5000/");
        }

        public async Task<string> GetHelloAsync()
        {
            var response = await _client.GetAsync("api/hello");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}