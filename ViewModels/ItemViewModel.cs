using System.ComponentModel.DataAnnotations;

namespace KickVault.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel()
        {
            ReleaseDate = DateTime.Today;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Photo of the item is Required!")]
        public string ImageURL { get; set; } = null!;

        [Required(ErrorMessage = "Add name of the model")]
        public string Model { get; set; } = null!;

        [StringLength(200, ErrorMessage = "Description is too long")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Price is Required!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Size is Required!")]
        public int? Size { get; set; }
        [Required(ErrorMessage = "Release Date is Required!")]
        public DateTime ReleaseDate { get; set; }
    }
}
