using Machine.Database;
using Machine.Database.Data.AdminSite;

namespace Machine.BusinessLogic.CustomerPanel
{
    public class VoucherLogic
    {
        private readonly MachineContext _context;
        public VoucherLogic(MachineContext context)
        {
            _context = context;
        }

        public void AddNewVoucher()
        {
            var tempVoucher = new Voucher()
            {
                IsActive = true,
            };

            _context.Voucher?.Add(tempVoucher);
            _context.SaveChanges();
        }
        public void FinishVoucher()
        {
            var tempVoucher = _context.Voucher!
                .Where(v => v.IsActive == true)
                .FirstOrDefault();

            if(tempVoucher != null)
            {
                tempVoucher.IsActive = false;
            };

            _context.SaveChanges();
        }

    }
}
