using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp.NetCoreProject.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var messgaes = c.Messages.Where(i=>i.Status==true).ToList();
            var messgaes2 = c.Messages.Where(i=>i.Status==false).ToList();
            ViewBag.messgaes2=messgaes2;
            return View(messgaes);
        }

        public IActionResult DeleteMessage(int id)
        {
          var message=c.Messages.Where(i => i.MessageID == id).FirstOrDefault();

            if(message!=null)
            {
                c.Messages.Remove(message);
                c.SaveChanges();

                return Redirect("/contact/index");
            }

            return View();
        }

        public IActionResult OkeyMesagge(int id)
        {
            var message=c.Messages.Where(i=>i.MessageID == id).FirstOrDefault();

            message.Status = false;

            c.Messages.Update(message);
            c.SaveChanges();

                return Redirect("/contact/index");

        }
        public IActionResult NoMesagge(int id)
        {
            var message = c.Messages.Where(i => i.MessageID == id).FirstOrDefault();

            message.Status = true;

            c.Messages.Update(message);
            c.SaveChanges();

            return Redirect("/contact/index");

        }
    }
}
