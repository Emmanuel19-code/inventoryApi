using inventoryApi.Domain;
using inventoryApi.Domain.Contracts;

namespace inventoryApi.Services
{
    public interface IProductService
    {
      Task GetProducts();
      Task<Response<Product>> AddProduct(CreateProduct request);
      Task<Response<List<Product>>> SearchProduct(string productName);
    }
}