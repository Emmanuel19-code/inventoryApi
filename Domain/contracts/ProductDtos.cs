using System.Globalization;

namespace inventoryApi.Domain.Contracts
{
    public class CreateProduct
    {
        public string Name {get;set;}
        public double Price {get;set;}
        public int StockQuantity {get;set;}
        public decimal Rating {get;set;}
    }
}