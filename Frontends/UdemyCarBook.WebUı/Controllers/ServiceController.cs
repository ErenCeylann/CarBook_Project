using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.ServiceDtos;
using UdemyCarBook.Dto.TestimonialDtos;

namespace UdemyCarBook.WebUı.Controllers
{
    public class ServiceController : Controller
    {
        

        public async Task< IActionResult> Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
