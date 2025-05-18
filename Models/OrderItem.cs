using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KickVault.Models
{
    public class OrderItem
    {
        [Required]
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; } = null!;

        [Required]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PriceAtPurchase { get; set; }

        public decimal Total => Quantity * PriceAtPurchase;
    }
}
