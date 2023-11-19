using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreProject.ViewComponents.Contact
{
    public class ContactDetailsList:ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();

            return View(values);
        }
    }
}
