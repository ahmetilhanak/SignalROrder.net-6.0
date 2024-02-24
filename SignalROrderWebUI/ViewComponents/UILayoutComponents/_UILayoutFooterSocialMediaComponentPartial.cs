using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.ContactVM;
using SignalROrderWebUI.ViewModels.SliderVM;
using SignalROrderWebUI.ViewModels.SocialMediaVM;

namespace SignalROrderWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutFooterSocialMediaComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UILayoutFooterSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7260/api/SocialMedia");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSocialMediaVM>>(jsonData);
                return View(values);
            }
            return View();

        }
    }
}
