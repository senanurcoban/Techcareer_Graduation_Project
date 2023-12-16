using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
