using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Repository;
using Services.Models;

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
        public async Task<IEnumerable<ProductDTO>> SearchProductsAsync(string searchTerm)
        {
            var products = await _productRepository.FindProductsAsync(searchTerm);
            var productDtos = Mapper.Map<IEnumerable<ProductDTO>>(products);
            return productDtos;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.FindProductById(id);
        }
    }
}
