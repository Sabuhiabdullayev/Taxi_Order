using BussinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace TaxiApi.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpGet]
        public IActionResult list()
        {
            var values = _orderServices.TGetList();
            return Ok(values);
            
        }
        [HttpPost]
        public IActionResult insert(Order order)
        {
            _orderServices.Tinsert(order);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
          var Getid= _orderServices.TgetById(id);
            _orderServices.Tdelete(Getid);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult find(int id)
        {
          var GetId= _orderServices.TgetById(id);
            return Ok(GetId);
        }
        [HttpPut]
        public IActionResult update(Order order)
        {
            var GetId = _orderServices.TgetById(order.Id);

       
                if (GetId == null)
                {
                    return NotFound();
                }
                else
                {
                    GetId.AppUserId = GetId.AppUserId;
                    GetId.AppUserName = GetId.AppUserName;
                    GetId.FromWhere = order.FromWhere;
                    GetId.Where = order.Where;
                    GetId.DateOfDeparture = order.DateOfDeparture;
                    GetId.DateOfPosting = GetId.DateOfPosting;
                    GetId.FromWhereDate = order.FromWhereDate;
                    GetId.WhereDate = order.WhereDate;
                    GetId.FullHour = order.FullHour;
                    GetId.Price = order.Price;
                    GetId.TransportationType = order.TransportationType;
                    GetId.Phone = order.Phone;
                _orderServices.Tupdate(GetId);
                    return Ok();
                }

            
        }

        [HttpGet("AppUserOrder")]
        public IActionResult AppUserOrder(int id)
        {
            var values = _orderServices.TGetList().Where(x => x.AppUserId == id);
            return Ok(values);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(string? FromWhere, string? Where, string? Date)
        {
            using (var context = new Context())
            {
                var order = context.Orders.AsQueryable();
                if (!string.IsNullOrEmpty(FromWhere))
                {
                    order = order.Where(e => e.FromWhere.Contains(FromWhere));
                }
                if (!string.IsNullOrEmpty(Where))
                {
                    order = order.Where(e => e.Where.Contains(Where));
                }
                if (!string.IsNullOrEmpty(Date))
                {
                    order = order.Where(e => e.DateOfDeparture.Contains(Date));
                }

                return Ok(order.ToList());
            }
        }
    }
}
