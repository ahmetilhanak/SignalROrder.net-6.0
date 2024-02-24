using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
