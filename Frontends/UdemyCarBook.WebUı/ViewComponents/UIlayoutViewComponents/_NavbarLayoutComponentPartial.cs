using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.ViewComponents.UIlayoutViewComponents
{
    public class _NavbarLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
