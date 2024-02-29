using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Taxi.Dal.Entities;

namespace Taxi.Areas.Admin.ViewComponents.User
{
    public class _AdminIsAuthentecatedNavbarImg:ViewComponent
    {
       private readonly UserManager<AppUser> _userManager;

        public _AdminIsAuthentecatedNavbarImg(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }
    }
}
