
using Microsoft.AspNetCore.Mvc;

namespace Taxi.ViewComponents.Layout
{
    public class _TopBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
