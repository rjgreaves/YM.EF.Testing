using System.Data.Entity;

namespace YM.EF.Testing.Data
{
    public class ShopDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
