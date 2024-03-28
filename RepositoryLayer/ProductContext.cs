using Domin;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}