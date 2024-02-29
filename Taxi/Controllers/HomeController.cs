using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using Taxi.Models;
using Taxi.Models.Order;

namespace Taxi.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Search(OrderSearchModel search)
        {
            if (!string.IsNullOrEmpty(search.FromWhere) && !string.IsNullOrEmpty(search.Where) && !string.IsNullOrEmpty(search.Date))
            {
                ViewBag.FromWhere = search.FromWhere;
                ViewBag.Where = search.Where;
                ViewBag.Date = search.Date;
                string apiUrl = "http://localhost:5024/api/Order/GetAll?";
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync(apiUrl + "FromWhere=" + search.FromWhere + "&" + "Where=" + search.Where + "&" + "Date=" + search.Date);
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<OrderAllList>>(jsonData);
                    return View(values);
                }
                return View();
            }
            else
            {
                return NotFound();
            }
          
        }
        public IActionResult Error404(int Code)
        {
            return View();
        }
    }
}