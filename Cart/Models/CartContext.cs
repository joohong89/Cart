using Microsoft.EntityFrameworkCore;

namespace Cart.Models
{
    public class CartContext: DbContext 
    {
        public CartContext(DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<CartMaster> Carts { get; set; } = null!;
    }
}
