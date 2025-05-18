using System.ComponentModel.DataAnnotations;

namespace KickVault.Models
{
    public class Item
    {
        public Item()
        {
            OrderItems = new HashSet<OrderItem>();
        }
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int? Size { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
