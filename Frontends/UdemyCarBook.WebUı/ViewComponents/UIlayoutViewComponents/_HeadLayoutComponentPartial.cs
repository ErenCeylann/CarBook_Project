using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.ViewComponents.UIlayoutViewComponents
{
    public class _HeadLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
