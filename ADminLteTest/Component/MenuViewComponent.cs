using Microsoft.AspNetCore.Mvc;

namespace ADminLteTest.Component
{
    public class MenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
