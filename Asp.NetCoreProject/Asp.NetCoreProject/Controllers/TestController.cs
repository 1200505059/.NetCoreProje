using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
