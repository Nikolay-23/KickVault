namespace KickVault.ViewModels
{
    public class FavoriteViewModel
    {
        public int ItemId { get; set; }
        public string ImageURL { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int? Size { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
