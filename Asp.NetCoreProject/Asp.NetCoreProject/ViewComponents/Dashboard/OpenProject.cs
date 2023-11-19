using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp.NetCoreProject.ViewComponents.Dashboard
{
    public class OpenProject : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var portfolios = c.Portfolios.ToList();
           
            return View(portfolios);
        }
    

    }
}
