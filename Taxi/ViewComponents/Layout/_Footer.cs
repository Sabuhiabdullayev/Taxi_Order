using Microsoft.AspNetCore.Mvc;

namespace Taxi.ViewComponents.Layout
{
    public class _Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
