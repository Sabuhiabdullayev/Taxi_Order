using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Taxi.Dal.Entities;

namespace Taxi.ViewComponents.User
{
	public class _LayoutAuthenticatedUser:ViewComponent
	{
		UserManager<AppUser> _userManager;

		public _LayoutAuthenticatedUser(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var values = _userManager.Users.FirstOrDefault(x => x.Id == user.Id);
			return View(values);
		}
	}
}
