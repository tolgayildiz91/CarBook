using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailSideBarSearchBoxComponentPartial:ViewComponent
    {
        public IViewComponentResult InvokeAsync()
        {
            return View();
        }
    }
}
