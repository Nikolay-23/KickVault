using KickVault.Models.Commons;
using System.ComponentModel.DataAnnotations;

namespace KickVault.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } = null!;
        //public ApplicationUser User { get; set; } = null!;


        public DateTime OrderDate { get; set; } = DateTime.UtcNow;


        public OrderStatus Status { get; set; } = OrderStatus.Pending;


        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();


        public decimal TotalPrice => Items.Sum(i => i.Quantity * i.PriceAtPurchase);


        [Required]
        [StringLength(255)]
        public string ShippingAddress { get; set; } = null!;

        [Phone]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        public string? ContactEmail { get; set; }


        public string? PaymentMethod { get; set; } // e.g., "Credit Card", "Cash on Delivery"

        public bool IsPaid { get; set; } = false;
    }
}
