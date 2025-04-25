using inventoryApi.Domain;
using inventoryApi.Domain.Contracts;

namespace inventoryApi.Services
{
    public interface IProductService
    {
      Task<Response<List<Product>>> GetProducts();
      Task<Response<Product>> AddProduct(CreateProduct request);
      Task<Response<List<Product>>> SearchProduct(string productName);
    }
}