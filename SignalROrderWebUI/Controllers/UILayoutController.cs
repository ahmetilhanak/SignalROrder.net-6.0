using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
