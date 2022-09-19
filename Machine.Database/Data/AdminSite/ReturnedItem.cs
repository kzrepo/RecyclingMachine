using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Machine.Database.Data.AdminSite
{
    public class ReturnedItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReturnedItem { get; set; }

        public int IdVoucher { get; set; }
        public Voucher? Voucher { get; set; }

        [Required(ErrorMessage = "Item type: bottle or can")]
        [MaxLength(6)]
        [Display(Name = "Item Type")]
        public string? ItemType { get; set; }

        [Required(ErrorMessage = "Item price")]
        [MaxLength(20)]
        public int Price { get; set; }
    }
}
