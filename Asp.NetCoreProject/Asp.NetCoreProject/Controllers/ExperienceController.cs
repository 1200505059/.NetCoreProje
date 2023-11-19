using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager=new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddExperience()
        { 
            return View(); 
        }
       
        
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
             experienceManager.Tadd(experience);
            return RedirectToAction("Index");
        }
       
        
        public IActionResult  DeleteExperience(int id) 
        {
            var values= experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
       
        
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values= experienceManager.TGetById(id);
            return View(values);
        }
       
        
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
