using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Taxi.Dal.Entities;

namespace Taxi.Areas.Admin.ViewComponents.User
{
    public class _AdminAllUserList:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _AdminAllUserList(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
    }
}
