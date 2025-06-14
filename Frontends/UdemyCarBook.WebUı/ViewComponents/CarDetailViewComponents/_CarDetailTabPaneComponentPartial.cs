using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailTabPaneComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
