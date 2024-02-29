using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Taxi.Dal.Entities;

namespace Taxi.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet("Driver")]
        [Route("{controller=User}/{action=Driver}/{userName?}")]
        public IActionResult Driver(string userName)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.UserName == userName);
            if(userName!=null & user != null)
            {
                return View(user);
            }
            return NotFound();
        }
       
    }
}
