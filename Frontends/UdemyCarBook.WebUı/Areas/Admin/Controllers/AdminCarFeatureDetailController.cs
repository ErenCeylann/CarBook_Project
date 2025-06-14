using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using UdemyCarBook.Dto.CarFeatureDtos;
using UdemyCarBook.Dto.CategoriesDtos;
using UdemyCarBook.Dto.FeatureDtos;
using UdemyCarBook.Dto.LocationDtos;

namespace UdemyCarBook.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7182/api/CarFeature?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureDto>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(List<ResultCarFeatureDto> resultCarFeatureDtos)
        {
            foreach (var item in resultCarFeatureDtos)
            {
                if (item.Available)
                {
                    var client = _httpClientFactory.CreateClient();
                    var responseMessage = await client.GetAsync("https://localhost:7182/api/CarFeature/UpdateCarFeatureAvailableChangToTrue?id=" + item.CarFeatureId);
                }
                else
                {
                    var client = _httpClientFactory.CreateClient();
                    var responseMessage = await client.GetAsync("https://localhost:7182/api/CarFeature/UpdateCarFeatureAvailableChangToFalse?id=" + item.CarFeatureId);
                }
                
            }
            return RedirectToAction("Index","AdminCar");

        }
        [HttpGet]
        public async Task<IActionResult> CreateFeatureById()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7182/api/Feature");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
