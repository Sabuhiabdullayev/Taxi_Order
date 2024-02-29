using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Taxi.Dal.Entities;

namespace Taxi.ViewComponents.Order
{
    public class _OrderListFooterMemberImg:ViewComponent
    {
        UserManager<AppUser> _userManager;

        public _OrderListFooterMemberImg(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IViewComponentResult Invoke(int id)
        {
            var user = _userManager.Users.Where(x => x.Id == id).ToList();
            return View(user);
        }
    }
}
