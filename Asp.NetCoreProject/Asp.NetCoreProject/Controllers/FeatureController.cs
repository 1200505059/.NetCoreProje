using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.Controllers
{
    public class FeatureController : Controller
    {
 FeatureManager featuremanager= new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = featuremanager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featuremanager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
