using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.AboutVM;
using SignalROrderWebUI.ViewModels.RestaurantTableVM;
using System.Text;

namespace SignalROrderWebUI.Controllers
{
	public class RestaurantTablesController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public RestaurantTablesController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7260/api/RestaurantTable");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultRestaurantTableVM>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public IActionResult CreateRestaurantTable()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateRestaurantTable(CreateRestaurantTableVM createRestaurantTableVM)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createRestaurantTableVM);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PostAsync("https://localhost:7260/api/RestaurantTable", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
				;
			}

			return View();
		}

		public async Task<IActionResult> DeleteRestaurantTable(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7260/api/RestaurantTable/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");

			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateRestaurantTable(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7260/api/RestaurantTable/GetRestaurantTable/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateRestaurantTableVM>(jsonData);
				return View(values);
			}
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> UpdateRestaurantTable(UpdateRestaurantTableVM updateRestaurantTableVM)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateRestaurantTableVM);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PutAsync("https://localhost:7260/api/RestaurantTable", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");

			}

			return View();
		}

		[HttpGet]
        public async Task<IActionResult> TableListByStatus()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7260/api/RestaurantTable");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRestaurantTableVM>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
