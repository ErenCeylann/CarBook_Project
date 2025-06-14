using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UdemyCarBook.Dto.CarDtos;

namespace UdemyCarBook.WebUı.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardChart2ComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardChart2ComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7182/api/Car/GetBrandByCarCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();


                var jObject = JObject.Parse(jsonData);
                var resultJson = jObject["result"]!.ToString();

                var values = JsonConvert.DeserializeObject<List<BrandCarCountDto>>(resultJson);
                return View(values);
            }

            return View(new List<BrandCarCountDto>());
        }
    }
}
