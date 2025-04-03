namespace inventoryApi.Domain.Entities
{
    public class SalesSummary
    {
        public Guid SalesSummaryId {get;set;}
        public Double TotalValue {get;set;}
        public double ChangePercentage {get;set;}
        public DateTime DateCreated {get;set;}
    }
}