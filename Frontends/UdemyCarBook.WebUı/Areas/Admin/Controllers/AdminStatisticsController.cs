using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AuthorDtos;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            #region istatislik 1
            var responseMessage = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.aracSayisi = values.carCount;
            }
            #endregion

            #region istatislik 2
            var responseMessage2 = await client.GetAsync("https://localhost:7182/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.lokasyonSayisi = values2.locationCount;
            }
            #endregion

            #region istatislik 3
            var responseMessage3 = await client.GetAsync("https://localhost:7182/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.yazarSayisi = values3.authorCount;
            }
            #endregion

            #region istatislik 4
            var responseMessage4 = await client.GetAsync("https://localhost:7182/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogSayisi = values4.blogCount;
            }
            #endregion

            #region istatislik 5
            var responseMessage5 = await client.GetAsync("https://localhost:7182/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.markaSayisi = values5.brandCount;
            }
            #endregion

            #region istatislik 6
            var responseMessage6 = await client.GetAsync("https://localhost:7182/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.GetAvgRentPriceForDaily = values6.avgRentPriceForDaily.ToString("0.00");
            }
            #endregion

            #region istatislik 7
            var responseMessage7 = await client.GetAsync("https://localhost:7182/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.avgRentPriceForWeekly = values7.avgRentPriceForWeekly.ToString("0.00");
            }
            #endregion

            #region istatislik 8
            var responseMessage8 = await client.GetAsync("https://localhost:7182/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.avgRentPriceForMonthly = values8.avgRentPriceForMonthly.ToString("0.00");
            }
            #endregion

            #region istatislik 9
            var responseMessage9 = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.carCountByTransmissionIsAuto = values9.carCountByTransmissionIsAuto;
            }
            #endregion

            #region istatislik 10
            var responseMessage10 = await client.GetAsync("https://localhost:7182/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.brandNameByMaxCar = values10.brandNameByMaxCar;
            }
            #endregion

            #region istatislik 11
            var responseMessage11 = await client.GetAsync("https://localhost:7182/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.blogTitleByMaxBlogComment = values11.blogTitleByMaxBlogComment;
            }
            #endregion

            #region istatislik 12
            var responseMessage12 = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarCountByKmLessThan1000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.GetCarCountByKmLessThan1000 = values12.carCountByKmLessThan1000;
            }
            #endregion

            #region istatislik 13
            var responseMessage13 = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarCountByFuelGasolinaOrDisel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.GetCarCountByFuelGasolinaOrDisel = values13.carCountByFuelGasolinaOrDisel;
            }
            #endregion

            #region istatislik 14
            var responseMessage14 = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.GetCarCountByFuelElectric = values14.carCountByFuelElectric;
            }
            #endregion

            #region istatislik 15
            var responseMessage15 = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.carBrandAndModelByRentPriceDailyMax = values15.carBrandAndModelByRentPriceDailyMax;
            }
            #endregion

            #region istatislik 16
            var responseMessage16 = await client.GetAsync("https://localhost:7182/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.carBrandAndModelByRentPriceDailyMin = values16.carBrandAndModelByRentPriceDailyMin;
            }
            #endregion

            return View();
        }
    }
}
