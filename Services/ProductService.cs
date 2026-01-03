using MockWebStoreAPI.Data;
using MockWebStoreAPI.DataModels;

namespace MockWebStoreAPI.Services
{
    public class ProductService
    {
        private readonly MockWebStoreDbContext _dbContext;

        public ProductService(MockWebStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }        
    }
}