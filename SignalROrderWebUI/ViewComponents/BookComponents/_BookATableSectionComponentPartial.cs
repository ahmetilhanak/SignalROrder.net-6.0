using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalROrderWebUI.ViewModels.BookingVM;
using System.Net.Http;
using System.Text;

namespace SignalROrderWebUI.ViewComponents.BookComponents
{
    public class _BookATableSectionComponentPartial:ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View();
        }

        
    }
}
