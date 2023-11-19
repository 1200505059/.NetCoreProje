using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.Tadd(service);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetById(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = serviceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
