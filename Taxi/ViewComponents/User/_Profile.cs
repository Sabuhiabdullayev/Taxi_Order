using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Taxi.Dal.Entities;

namespace Taxi.ViewComponents.User
{
    public class _Profile:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _Profile(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke(int id)
        {
            var user =  _userManager.Users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }
    }
}
