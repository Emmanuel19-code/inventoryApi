namespace inventoryApi.Domain.Entities
{
    public class Sales 
    {
        public Guid SalesId {get;set;}
        public Guid ProductId {get;set;}
        public DateTime DateCreated {get;set;}
        public int Quantity {get;set;}
        public double UnitPrice {get;set;}
        public double TotalAmount {get;set;}
    }
}