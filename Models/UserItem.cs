using Microsoft.AspNetCore.Identity;

namespace KickVault.Models
{
    public class UserItem
    {
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
