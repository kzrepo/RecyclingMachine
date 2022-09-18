using Machine.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Machine.CustomerPanel.Controllers.Components
{
    public class VoucherDetailsComponent : ViewComponent
    {
        private readonly MachineContext _context;
        public VoucherDetailsComponent(MachineContext context) => _context = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("VoucherDetailsComponent", await _context.ItemParameter!.ToListAsync());
        }
    }
}
