using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.Concrete;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.DataAccessLayer.EntityFramework;

namespace PizzaPan.PresentationLayer.ViewComponents.About
{
    public class _OurTeamPartial:ViewComponent
    {

        OurTeamManager ourTeamManager = new OurTeamManager(new EfOurTeamDal());
        public IViewComponentResult Invoke()
        {
            var values = ourTeamManager.TGetList();
            return View(values);
        }

    }
}
