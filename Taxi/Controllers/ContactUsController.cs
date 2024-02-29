using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Taxi.Models.Contact;

namespace Taxi.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactUsAdd contactUsAdd)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(contactUsAdd);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5024/api/ContactUs", content);
            if (response.IsSuccessStatusCode)
            {
                return Json(response);
            }
            return View();
        }
    }
}
