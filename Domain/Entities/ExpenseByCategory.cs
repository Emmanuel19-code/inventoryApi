using System.ComponentModel.DataAnnotations;

namespace inventoryApi.Domain.Entities
{
    public class ExpenseByCategory
    {
        [Key]
        public Guid ExpenseByCategoryId {get;set;}
        public Guid ExpenseSummaryid {get;set;}
        public DateTime DateCreated {get;set;}
        public string Category {get;set;}
        public double Amount {get;set;}
    }
}