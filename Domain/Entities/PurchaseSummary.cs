namespace inventoryApi.Domain.Entities
{
    public class PurchaseSummary
    {
        public Guid PurchaseSummaryId {get;set;}
        public double TotalPurchased {get;set;}
        public double ChangePercentage {get;set;}
        public DateTime DateCreated {get;set;}
    }
}