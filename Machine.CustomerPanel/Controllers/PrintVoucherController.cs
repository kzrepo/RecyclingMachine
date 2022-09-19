using Microsoft.AspNetCore.Mvc;

namespace Machine.CustomerPanel.Controllers
{
    public class PrintVoucherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
