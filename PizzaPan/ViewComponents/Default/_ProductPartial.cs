using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.Concrete;
using PizzaPan.DataAccessLayer.EntityFramework;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _ProductPartial : ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        public IViewComponentResult Invoke()
        {
            var values = productManager.TGetList();
            return View(values);
        }
    }
}
