using Microsoft.AspNetCore.Mvc;

namespace SignalROrderWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableSectionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
