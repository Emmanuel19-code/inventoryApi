using System.ComponentModel.DataAnnotations;

namespace inventoryApi.Domain.Entities
{
    public class Purchases
    {
        [Key]
        public Guid PurchaseId {get;set;}
        public Guid ProductId {get;set;}
        public DateTime DateCreated {get;set;}
        public int Quantity {get;set;}
        public double UnitCost {get;set;}
        public double TotalCost {get;set;}
    }
}