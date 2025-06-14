using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUı.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
