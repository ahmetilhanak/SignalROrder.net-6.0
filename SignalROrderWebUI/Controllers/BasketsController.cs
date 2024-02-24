using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.BasketVM;
using System.Text;

namespace SignalROrderWebUI.Controllers
{
    public class BasketsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BasketsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("https://localhost:7260/api/Baskets");
            //var responseMessage = await client.GetAsync("https://localhost:7260/api/Baskets/GetBasketByRestaurantTableNumber/4");
            var responseMessage = await client.GetAsync("https://localhost:7260/api/Baskets/GetBasketWithProductNameByRestaurantTableNumber/4");
            
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                //var values = JsonConvert.DeserializeObject<List<ResultBasketVM>>(jsonData);
                var values = JsonConvert.DeserializeObject<List<ResultBasketWithProductVM>>(jsonData);
                return View(values);
            }
            return View();

            
        }

        [HttpGet]
        public IActionResult CreateBasket()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBasket(CreateBasketVM createBasketVM)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBasketVM);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7260/api/Baskets", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
                
            }

            return View();
        }

       

        //[HttpPost("[action]")]
        //public async Task<IActionResult> AddAndImage([FromBody] CreateCampaignAndImageCommand createCampaignAndImageCommand)
        //{
        //    CreatedCampaignDto result = await Mediator.Send(createCampaignAndImageCommand);

        //    return Created("", result);
        //}

        public async Task<IActionResult> DeleteBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7260/api/Baskets/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
            //return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7260/api/Baskets/GetBasket/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBasketVM>(jsonData);
                return View(values);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateBasket(UpdateBasketVM updateBasketVM)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBasketVM);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PutAsync("https://localhost:7260/api/Baskets", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
