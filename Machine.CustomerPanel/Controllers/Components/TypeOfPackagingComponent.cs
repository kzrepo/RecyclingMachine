using Microsoft.AspNetCore.Mvc;

namespace Machine.CustomerPanel.Controllers.Components
{
    public class TypeOfPackagingComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("TypeOfPackagingComponent");
        }
    }
}
