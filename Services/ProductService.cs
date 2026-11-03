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

        public async Task<List<ProductDto>> GetAllProductsByCategoryAsync(ProductDtoCategory category)
        {
            // IEnumerable<Product> allows covariant assignment from derived list types (List<WeaponProduct>, List<ArmourProduct>, etc)
            IEnumerable<Product> products = category switch
            {
                ProductDtoCategory.Weapon => await _dbContext.Products.OfType<WeaponProduct>().ToListAsync(),
                ProductDtoCategory.Armour => await _dbContext.Products.OfType<ArmourProduct>().ToListAsync(),
                _ => throw new ArgumentException("Unknown category")
            };
            
            return products.Select(p => ProductDto.FromEntity(p)).ToList();
        }
    }
}