using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Machine.Database.Data.AdminSite
{
    public class Voucher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Voucher number")]
        public int IdVoucher { get; set; }

        [Display(Name = "Voucher active")]
        public bool IsActive { get; set; }

        [Display(Name = "Voucher printed")]
        public bool IsPrinted { get; set; }

        public List<ReturnedItem>? ReturndItems { get; set; }
    }
}
