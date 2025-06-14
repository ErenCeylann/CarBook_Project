using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.ReviewDtos;

namespace UdemyCarBook.WebUı.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailCommentByCarIdComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CarDetailCommentByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            id = ViewBag.carId;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7182/api/Review?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultReviewByCarIdDto>>(jsonData);
                ViewBag.fiveStar = values.Count(x=>x.CustomerRaytingValue == "5");
                ViewBag.fourStar = values.Count(x => x.CustomerRaytingValue == "4");
                ViewBag.threeStar = values.Count(x => x.CustomerRaytingValue == "3");
                ViewBag.twoStar = values.Count(x => x.CustomerRaytingValue == "2");
                ViewBag.oneStar = values.Count(x => x.CustomerRaytingValue == "1");
                int star = values.Count();
                ViewBag.totalComment = star;
                ViewBag.fiveRating = star == 0 ? 0 : values.Count(x => x.CustomerRaytingValue == "5") * 100.0 / star;
                ViewBag.fourRating = star == 0 ? 0 : values.Count(x => x.CustomerRaytingValue == "4") * 100.0 / star;
                ViewBag.threeRating = star == 0 ? 0 : values.Count(x => x.CustomerRaytingValue == "3") * 100.0 / star;
                ViewBag.twoRating = star == 0 ? 0 : values.Count(x => x.CustomerRaytingValue == "2") * 100.0 / star;
                ViewBag.oneRating = star == 0 ? 0 : values.Count(x => x.CustomerRaytingValue == "1") * 100.0 / star;
                return View(values);
                

            }
            return View();
        }
    }
}
