using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace KickVault.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public IdentityUser? User { get; set; }

        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal PriceAtAddTime { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        public string? SessionId { get; set; }

        public decimal Total => Quantity * PriceAtAddTime;
    }
}
