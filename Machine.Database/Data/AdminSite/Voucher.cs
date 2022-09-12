using System.ComponentModel.DataAnnotations;

namespace Machine.Database.Data.AdminSite
{
    public class Voucher
    {
        [Key]
        [Display(Name = "Voucher number")]
        public int IdVoucher { get; set; }

        [Required(ErrorMessage = "Set DateTime value")]
        [Display(Name = "Creation date")]
        public DateTime Create { get; set; }
    }
}
