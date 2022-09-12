using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Machine.Database.Data.AdminSite
{
    public class ItemParameter
    {
        [Key]
        public int IdParameter { get; set; }

        [Required(ErrorMessage = "Item type: bottle or can")]
        [MaxLength(6, ErrorMessage = "bottle or can")]
        [Display(Name = "Item Type")]
        public string? ItemType { get; set; }

        [Required(ErrorMessage = "Parameter type: weight, manufacturer, size, material, processing, cena")]
        [MaxLength(20, ErrorMessage = "weight / manufacturer / size / material / processing / price")]
        [Display(Name = "Parameter Type")]
        public string? ParameterType { get; set; }

        [Required(ErrorMessage = "Parameter value: weight (g), manufacturer name, size (mm), material type (glass, aluminium, plastic), time (milliseconds), price (kr)")]
        [MaxLength(30, ErrorMessage = "The value should contain max 30 characters")]
        public string? Value { get; set; }

        public string? Note { get; set; }
    }
}
