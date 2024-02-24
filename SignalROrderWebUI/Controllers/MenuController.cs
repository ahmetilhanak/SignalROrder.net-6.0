using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.BasketVM;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;

namespace SignalROrderWebUI.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBasket(int Id)
        {
            AddBasketIdVM addBasketIdVM = new AddBasketIdVM();
            addBasketIdVM.Id=Id;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addBasketIdVM);

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync($"https://localhost:7260/api/Baskets/AddBasket", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
                //return Json(responseMessage);
            }
            return View();
        }
    }

   
}
