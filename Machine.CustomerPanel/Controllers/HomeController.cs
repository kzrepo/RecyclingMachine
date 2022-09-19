using Machine.CustomerPanel.Models;
using Machine.Database;
using Machine.Database.Data.AdminSite;
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

        // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReturnedItem, Voucher, ItemType, Price")] ReturnedItem returnedItem)
        {
            if(ModelState.IsValid)
            {
                _context.Add(returnedItem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}