using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Taxi.Dal.Entities;
using Taxi.Models.Login;

namespace Taxi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
     
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel signUpView)
        {
            AppUser appUser = new AppUser()
            {
                Name=signUpView.Name,
                UserName = signUpView.UserName,
                Date = signUpView.Date,
                DateOfPosting= DateTime.Parse(DateTime.Now.ToShortTimeString()).ToString(),
                Email =signUpView.Email,
                Transportationtype="null",
                img="/Taxi/img/DefaultImg/default.png"
            };
            if (signUpView.Password == signUpView.ConfigPassword)
            {
                var result = await _userManager.CreateAsync(appUser, signUpView.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("MyOrder", "Order", new { area = "Member" });
                }
            };
            return View(signUpView);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model, string returnUrl)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("MyOrder", "Order", new {area="Member"});

                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Mate", "Order");
        }
    }
}
