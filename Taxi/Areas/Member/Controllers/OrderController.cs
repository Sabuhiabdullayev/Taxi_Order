using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Taxi.Areas.Member.Models.Order;
using Taxi.Dal.Entities;
using Taxi.Models.Order;

namespace Taxi.Areas.Member.Controllers
{
    [Area("Member")]
    public class OrderController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UserManager<AppUser> _userManager;
        public OrderController(IHttpClientFactory httpClientFactory, UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> MyOrder()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            var id = user.Id;
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5024/api/Order/AppUserOrder?id="+id);
			if (response.IsSuccessStatusCode)
			{
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<OrderAllList>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult MetaAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MetaAdd(OrderAdd orderAdd)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
           orderAdd.AppUserId= user.Id;
            orderAdd.AppUserName = user.UserName;
            orderAdd.DateOfPosting = DateTime.Parse(DateTime.Now.ToShortTimeString()).ToString();
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(orderAdd);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("http://localhost:5024/api/Order", content);
            if (response.IsSuccessStatusCode)
            {
                return Json(response);
            }
            return View();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"http://localhost:5024/api/Order/{id}");
            if (response.IsSuccessStatusCode)
            {
                return Json(response);
            }
            return View();
        }
   [HttpGet]
        public async Task<IActionResult> Update(int id)
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
        [HttpPut]
        public async Task<IActionResult> Update(OrderUpdate order)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(order);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("http://localhost:5024/api/Order", content);
            if (response.IsSuccessStatusCode)
            {
                return Json(jsonData);
            }
            return View();
        }
    }
}
