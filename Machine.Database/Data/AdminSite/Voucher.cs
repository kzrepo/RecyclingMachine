using System.ComponentModel.DataAnnotations;

namespace Machine.Database.Data.AdminSite
{
    public class Voucher
    {
        [Key]
        [Display(Name = "Voucher number")]
        public int IdVoucher { get; set; }

        [Required(ErrorMessage = "Set Voucher is active")]
        [Display(Name = "Voucher active")]
        public bool IsActive { get; set; }
    }
}
