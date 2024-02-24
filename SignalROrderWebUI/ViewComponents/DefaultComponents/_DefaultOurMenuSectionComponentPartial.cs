using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.DiscountVM;
using SignalROrderWebUI.ViewModels.ProductVM;

namespace SignalROrderWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuSectionComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurMenuSectionComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7260/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductVM>>(jsonData);
                return View(values);
            }
            return View();

        }
    }
}
