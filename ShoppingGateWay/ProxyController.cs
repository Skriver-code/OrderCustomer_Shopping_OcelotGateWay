using Microsoft.AspNetCore.Mvc;

namespace ShoppingGateWay
{
    [Route("[action]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public ProxyController(IHttpClientFactory httpClientFactory) 
        {
            _httpClient = httpClientFactory.CreateClient();
        }
        [HttpGet]
        public async Task<IActionResult> Customers()
            => await ProxyTo("https://localhost:7026/customers");

        [HttpGet]
        public async Task<IActionResult> Orders()
            => await ProxyTo("https://localhost:7132/orders");

        private async Task<ContentResult> ProxyTo(string url)
            => Content(await _httpClient.GetStringAsync(url));

    }
}
