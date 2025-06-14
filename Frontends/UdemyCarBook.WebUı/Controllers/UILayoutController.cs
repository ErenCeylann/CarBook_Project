using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
