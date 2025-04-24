using inventoryApi.Domain;
using inventoryApi.Domain.Contracts;
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

        public async Task<Response<Product>> AddProduct(CreateProduct request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                return Response<Product>.Fail("Product is required");
            }
            if (request.Price <= 0)
            {
                return Response<Product>.Fail("Product Price must not be 0 or less than");
            }

            var newProduct = new Product
            {
                Name = request.Name,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                Rating = request.Rating,
            };
            await _dbContext.Products.AddAsync(newProduct);
            await _dbContext.SaveChangesAsync();
            return Response<Product>.OK(newProduct, "Product Added");
        }

        public Task<Response<List<Product>>> SearchProduct(string productName)
        {
            throw new NotImplementedException();
        }
        public Task GetProducts()
        {
            throw new NotImplementedException();
        }

       

        
    }
}