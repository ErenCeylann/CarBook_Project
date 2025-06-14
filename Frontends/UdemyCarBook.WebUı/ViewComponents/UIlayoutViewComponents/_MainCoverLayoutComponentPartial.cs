using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.ViewComponents.UIlayoutViewComponents
{
    public class _MainCoverLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
