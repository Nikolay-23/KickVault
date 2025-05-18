using System.ComponentModel.DataAnnotations;

namespace KickVault.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
