using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        public IViewComponentResult InvokeAsync()
        {
            return View();
        }
    }
}
