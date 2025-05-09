using System.ComponentModel.DataAnnotations;

namespace inventoryApi.Domain.Entities
{
    public class ExpenseSummary
    {
        [Key]
        public Guid ExpenseSummaryid {get;set;}
        public double TotalExpenses {get;set;}
        public DateTime DateCreated {get;set;}
    }
}