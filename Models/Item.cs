using System.ComponentModel.DataAnnotations;

namespace KickVault.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ImageURL { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int? Size { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<UserItem> UserItems { get; set; } = new List<UserItem>();
    }
}
