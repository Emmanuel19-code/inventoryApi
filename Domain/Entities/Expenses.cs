using System.ComponentModel.DataAnnotations;

namespace inventoryApi.Domain.Entities
{
    public class Expenses 
    {
        [Key]
        public Guid ExpenseId {get;set;}
        public string Category {get;set;}
        public double Amount {get;set;}
        public DateTime DateCreated {get;set;}
    }
}