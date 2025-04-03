using inventoryApi.Infrastruture.Context;

namespace inventoryApi.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}