namespace inventoryApi.Domain
{
    public class Products
    {
        public Guid Id {get;set;}
        public string Name {get;set;}
        public double Price {get;set;}
        public double Decimal {get;set;}
        public int StockQuantity {get;set;}
    }
}