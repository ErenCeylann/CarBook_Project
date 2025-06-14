using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.ViewComponents.UIlayoutViewComponents
{
    public class _ScriptLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
