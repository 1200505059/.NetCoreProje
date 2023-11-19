using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
