using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Taxi.Dal.Entities;
using Newtonsoft.Json;
using Taxi.Models.Order;

namespace Taxi.Areas.Member.ViewComponents.Order
{
    public class _MyOrderUpdate:ViewComponent
    {
        IHttpClientFactory _httpClientFactory;

        public _MyOrderUpdate(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
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
