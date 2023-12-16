using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.Concrete;
using PizzaPan.DataAccessLayer.EntityFramework;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _ContactUsPartial:ViewComponent
    {
        ContactUsManager contactUsManager = new ContactUsManager(new EfContactUsDal());

        public IViewComponentResult Invoke()
        {
            var value = contactUsManager.TGetByID(3);
            
            return View(value);
        }
    }
}
