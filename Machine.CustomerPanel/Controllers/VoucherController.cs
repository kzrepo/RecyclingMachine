using Machine.BusinessLogic.CustomerPanel;
using Machine.Database;
using Microsoft.AspNetCore.Mvc;

namespace Machine.CustomerPanel.Controllers
{
    public class VoucherController : Controller
    {
        public readonly MachineContext _context;
        public VoucherController(MachineContext context)
        {
            _context = context;
        }

        public IActionResult AddNewVoucher()
        {
            VoucherLogic voucherLogic = new(_context);
            voucherLogic.AddNewVoucher();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult FinishVoucher()
        {
            VoucherLogic voucherLogic = new(_context);
            voucherLogic.FinishVoucher();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult PrintVoucher()
        {
            VoucherLogic voucherLogic = new(_context);
            voucherLogic.PrintVoucher();

            return RedirectToAction("Index", "Home");
        }
    }
}
