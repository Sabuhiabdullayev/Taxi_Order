using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Taxi.Areas.Member.Models.Account;
using Taxi.Dal.Entities;

namespace Taxi.Areas.Member.Controllers
{
	[Area("Member")]
	[AllowAnonymous]
	public class AccountController : Controller
	{
		UserManager<AppUser> _userManager;

		public AccountController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Settings()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			return View(user);
		}
		[HttpPost]
		public async Task<IActionResult> Settings(SettingsUpdateViewModel model)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (model.img != null)
			{
				var resurs = Directory.GetCurrentDirectory();
				var Extinsion = Path.GetExtension(model.img.FileName);
				var NewName = Guid.NewGuid() + Extinsion;
				var SaveLocation = resurs + "/wwwroot/Taxi/img/UserImg/" + NewName;
				var Stream = new FileStream(SaveLocation, FileMode.Create);
				await model.img.CopyToAsync(Stream);
				user.img = "/Taxi/img/UserImg/"+NewName;
			}
			else
			{
				user.img = user.img;
			}
			user.Name = model.Name;
			user.Email = model.Email;
			user.Date = model.Date;
			user.PhoneNumber = model.Phone;
		var result =await	_userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return RedirectToAction("MyOrder", "Order", new { area = "Member" });
			}
			return View(model);
		}
	}
}
