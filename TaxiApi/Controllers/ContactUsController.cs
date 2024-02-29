using BussinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaxiApi.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        IContactUsServices _contactUsServices;

        public ContactUsController(IContactUsServices contactUsServices)
        {
            _contactUsServices = contactUsServices;
        }

        [HttpGet]
        public IActionResult list()
        {
            var values = _contactUsServices.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insert(ContactUs contactUs)
        {
            _contactUsServices.Tinsert(contactUs);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var GetId = _contactUsServices.TgetById(id);
            _contactUsServices.Tdelete(GetId);
            return Ok();
        }
        [HttpPut]
        public IActionResult update(ContactUs contactUs)
        {
            var GetId = _contactUsServices.TgetById(contactUs.Id);
       
                if (GetId == null)
                {
                    return NotFound();
                }
                else
                {
                GetId.Name = contactUs.Name;
                GetId.Email = contactUs.Email;
                GetId.Subject = contactUs.Subject;
                GetId.Content = contactUs.Content;
                GetId.Date = contactUs.Date;
                _contactUsServices.Tupdate(GetId);
                    return Ok(contactUs);
                }
            }
        [HttpGet("{id}")]
        public IActionResult find(int? id)
        {
            var Getid = _contactUsServices.TgetById(id);
            if (Getid == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Getid);
            }
        }
   }  
 }
        
    

