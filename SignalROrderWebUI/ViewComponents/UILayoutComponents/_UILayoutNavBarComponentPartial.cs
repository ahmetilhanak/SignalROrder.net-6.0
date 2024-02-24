using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
