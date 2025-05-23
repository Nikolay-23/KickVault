using System.ComponentModel.DataAnnotations;

namespace KickVault.Models
{
    public class Item
    {
        public Item()
        {
            ReleaseDate = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImageURL { get; set; } = null!;
        [Required]
        public string Model { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int? Size { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<UserItem> UserItems { get; set; } = new List<UserItem>();
    }
}
