using Asp.NetCoreProject.Areas.User.Models;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreProject.Areas.User.Controllers
{
   
    //[Area("User")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            WriterUser wu = new WriterUser()
            {
                name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = p.ImageUrl

            };
            if(p.ConfirmPassword==p.Password && p.Password!=null) { 
            var result=await _userManager.CreateAsync(wu,p.Password);
           

            if (result.Succeeded )
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
              

            }
            }
            return View(p);
            
        }
    }
}
