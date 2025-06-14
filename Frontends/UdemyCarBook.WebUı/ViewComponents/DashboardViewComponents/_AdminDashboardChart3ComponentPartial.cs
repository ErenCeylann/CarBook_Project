using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.LocationDtos;

namespace UdemyCarBook.WebUı.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardChart3ComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;



        public _AdminDashboardChart3ComponentPartial(IHttpClientFactory httpClientFactory)

        {

            _httpClientFactory = httpClientFactory;

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7182/api/Location");

            if (responseMessage.IsSuccessStatusCode)

            {

                var jsondata = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsondata);

                return View(values);

            }

            return View();

        }
        }
    }

