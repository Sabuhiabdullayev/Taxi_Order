﻿using Microsoft.AspNetCore.Mvc;

namespace Taxi.ViewComponents.Layout
{
    public class _Navbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
