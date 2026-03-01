using Microsoft.EntityFrameworkCore;
using MockWebStoreAPI.Data;
using MockWebStoreAPI.DataModels;
using MockWebStoreAPI.DTO;

namespace MockWebStoreAPI.Services
{
    public class ProductService
    {
        private readonly MockWebStoreDbContext _dbContext;

        public ProductService(MockWebStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            List<ProductDto> result = new List<ProductDto>();
            List<Product> products = await _dbContext.Products.ToListAsync();

            foreach (Product p in products)
            {
                result.Add(ProductDto.FromEntity(p));
            }

            return result;
        }
    }
}