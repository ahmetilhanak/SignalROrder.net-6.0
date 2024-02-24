using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalROrderWebUI.ViewModels.IdentityVM;

namespace SignalROrderWebUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditVM userEditVM = new UserEditVM()
            {
                Surname = values.Surname,
                Name = values.Name,
                Username = values.UserName,
                Email = values.Email
            };
            return View(userEditVM);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserEditVM userEditVM)
        {
            if (userEditVM.Password == userEditVM.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Surname = userEditVM.Surname;
                user.Name=userEditVM.Name;
                user.Email = userEditVM.Email;
                user.UserName = userEditVM.Username;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,userEditVM.Password);

                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
