using Machine.CustomerPanel.Models;
using Machine.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Machine.CustomerPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly MachineContext _context;

        public HomeController(MachineContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Voucher!.OrderBy(v => v.IdVoucher).LastOrDefaultAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}