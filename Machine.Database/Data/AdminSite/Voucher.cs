using System.ComponentModel.DataAnnotations;

namespace Machine.Database.Data.AdminSite
{
    public class Voucher
    {
        [Key]
        [Display(Name = "Voucher number")]
        public int IdVoucher { get; set; }

        [Required(ErrorMessage = "Set Sesion value")]
        [Display(Name = "Session Id")]
        public string? Session { get; set; }

        [Required(ErrorMessage = "Set DateTime value")]
        [Display(Name = "Start date")]
        public DateTime Start { get; set; }

        [Display(Name = "End date")]
        public DateTime End { get; set; }
    }
}
