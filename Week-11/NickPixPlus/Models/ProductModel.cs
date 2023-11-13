using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace NickPixPlus.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Must enter valid product name as a string.")]
        public string? ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Must enter valid product description as a string.")]
        public string? ProductDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Must enter valid product image as a string.")]
        public string? ProductImage { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }
    }
}