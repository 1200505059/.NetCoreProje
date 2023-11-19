using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Asp.NetCoreProject.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfolioManager =new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {

            var values = portfolioManager.TGetList();


            return View(values);
        }
    }
}
