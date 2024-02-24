﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.AboutVM;
using SignalROrderWebUI.ViewModels.SliderVM;
using System.Text;

namespace SignalROrderWebUI.Controllers
{
	public class SliderController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public SliderController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7260/api/Sliders");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultSliderVM>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public IActionResult CreateSlider()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateSlider(CreateSliderVM createSliderVM)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createSliderVM);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PostAsync("https://localhost:7260/api/Sliders", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
				;
			}

			return View();
		}

		public async Task<IActionResult> DeleteSlider(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7260/api/Sliders/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");

			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateSlider(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7260/api/Sliders/GetSlider/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateSliderVM>(jsonData);
				return View(values);
			}
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> UpdateSlider(UpdateSliderVM updateSliderVM)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateSliderVM);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PutAsync("https://localhost:7260/api/Sliders", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");

			}

			return View();
		}
	}
}
