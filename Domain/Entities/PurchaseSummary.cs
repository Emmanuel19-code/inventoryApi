using System.ComponentModel.DataAnnotations;

namespace inventoryApi.Domain.Entities
{
    public class PurchaseSummary
    {
        [Key]
        public Guid PurchaseSummaryId {get;set;}
        public double TotalPurchased {get;set;}
        public double ChangePercentage {get;set;}
        public DateTime DateCreated {get;set;}
    }
}