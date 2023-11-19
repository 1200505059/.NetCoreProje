using Asp.NetCoreProject.Areas.User.Models;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Asp.NetCoreProject.Areas.User.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel p)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if(result.Succeeded)
                {
                return RedirectToAction("Index","Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kulllanıcı adı veya Şifre");
                }
            }
            return View();
        }
    }
}
