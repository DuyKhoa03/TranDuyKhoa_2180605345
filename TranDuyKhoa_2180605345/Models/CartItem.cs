using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TranDuyKhoa_2180605345.Models
{
    public class CartItem
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
