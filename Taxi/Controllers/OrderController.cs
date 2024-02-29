using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Taxi.Areas.Member.Models.Order;
using Taxi.Models.Order;

namespace Taxi.Controllers
{
    [AllowAnonymous]
    public class OrderController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Mate()
        {
            return View();
        }
        
       
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"http://localhost:5024/api/Order/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<OrderAllList>(jsonData);
                return View(json);
            }
            return View();
            
        }
    }
}
