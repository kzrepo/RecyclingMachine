using Machine.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Machine.AdminSite.Controllers
{
    public class VouchersController : Controller
    {
        private readonly MachineContext _context;

        public VouchersController(MachineContext context)
        {
            _context = context;
        }

        // GET: Voucher
        public async Task<IActionResult> Index()
        {
            return _context.Voucher != null ?
                        View(await _context.Voucher.ToListAsync()) :
                        Problem("Entity set 'MachineContext.Voucher'  is null.");
        }
    }
}
