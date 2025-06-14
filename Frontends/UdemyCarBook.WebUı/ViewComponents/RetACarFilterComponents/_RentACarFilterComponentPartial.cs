using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using UdemyCarBook.Dto.LocationDtos;

namespace UdemyCarBook.WebUı.ViewComponents.RetACarFilterComponents
{
    public class _RentACarFilterComponentPartial:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
