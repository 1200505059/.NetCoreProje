using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values= skillmanager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillmanager.Tadd(skill);
            return RedirectToAction("Index");

        }
        public IActionResult  DeleteSkill(int id) 
        {
            var values= skillmanager.TGetById(id);
            skillmanager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values=skillmanager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
           skillmanager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
