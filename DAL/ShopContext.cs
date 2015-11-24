using System.Data.Entity;

namespace DAL
{
    public class ShopContext : DbContext
    {
     /*   public static string connectionString = "Server=localhost;Database=Shop;user=sa;password=qwe123qwe123;";
        */
        public ShopContext()
            : base("name=ShopContext")
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
