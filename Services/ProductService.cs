using inventoryApi.Domain;
using inventoryApi.Domain.Contracts;
using inventoryApi.Infrastruture.Context;
using Microsoft.EntityFrameworkCore;

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
            Console.WriteLine(request.Name);
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

        public async Task<Response<List<Product>>> SearchProduct(string productName)
        {
            IQueryable<Product> query = _dbContext.Products;

            if (!string.IsNullOrWhiteSpace(productName))
            {
                query = query.Where(p => EF.Functions.Like(p.Name, $"%{productName}%"));
            }

            var products = await query.ToListAsync();

            if(products == null)
            {
                return Response<List<Product>>.Fail("Not Product Found");
            }

            return Response<List<Product>>.OK(products);
        }


        public async Task<Response<List<Product>>> GetProducts()
        {
            var products = await _dbContext.Products.ToListAsync();
            return Response<List<Product>>.OK(products);
            
        }
    }
}