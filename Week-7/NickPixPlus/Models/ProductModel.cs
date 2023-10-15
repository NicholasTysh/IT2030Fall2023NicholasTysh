using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace NickPixPlus.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; } = string.Empty;
        public string? ProductDescription { get; set; } = string.Empty;
        public string? ProductImage { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
    }
}