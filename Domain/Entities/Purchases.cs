namespace inventoryApi.Domain.Entities
{
    public class Purchases
    {
        public Guid PurchaseId {get;set;}
        public Guid ProductId {get;set;}
        public DateTiime DateCreated {get;set;}
        public int Quantity {get;set;}
        public double UnitCost {get;set;}
        public double TotalCost {get;set;}
    }
}