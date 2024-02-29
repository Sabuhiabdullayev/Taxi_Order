using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Taxi.Areas.Admin.Models.Order;

namespace Taxi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> AllList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5024/api/Order");
            if (response.IsSuccessStatusCode)
            {
                var jsondata = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<List<OrderAllList>>(jsondata);
                return View(json);
            }
            return View();
        }
    }
}
