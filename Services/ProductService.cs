using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService()
        {
            // Directly instantiate the ProductRepository here
            _productRepository = new ProductRepository();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }
        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
        {
            return await _productRepository.FindProductsAsync(searchTerm);
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.FindProductById(id);
        }
    }
}
