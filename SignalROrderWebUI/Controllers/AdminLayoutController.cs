using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
