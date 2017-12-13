using System.Data.Entity;

namespace BookShop.Models
{
    public class DatabaseContext
        : DbContext
    {
        public DatabaseContext()
            : base(@"data source=cntttest.vanlanguni.edu.vn;initial catalog=BookShop;user id=ppcrental;password=12345678;MultipleActiveResultSets=True")
        {
        }
        
        public DbSet<Order> Orders { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }
    }
}