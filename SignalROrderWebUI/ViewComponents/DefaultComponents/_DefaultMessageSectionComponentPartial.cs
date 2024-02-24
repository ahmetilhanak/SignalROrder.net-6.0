using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultMessageSectionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
