﻿using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
