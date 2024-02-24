using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
