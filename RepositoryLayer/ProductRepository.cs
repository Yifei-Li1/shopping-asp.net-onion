using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;
using System.Linq;


namespace Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ProductContext _context;

        public ProductRepository()
        {
            _context = new ProductContext();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<IEnumerable<Product>> FindProductsAsync(string searchTerm)
        {
            return await _context.Products
                .Where(p => p.SubCategory.Contains(searchTerm))
                                 .ToListAsync();
        }
        public async Task<Product> FindProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

    }
}