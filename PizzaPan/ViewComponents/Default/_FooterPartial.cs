using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
