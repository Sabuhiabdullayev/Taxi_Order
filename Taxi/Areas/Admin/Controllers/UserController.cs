using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Taxi.Dal.Entities;

namespace Taxi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult AllList()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            return View();
        }
    }
}
