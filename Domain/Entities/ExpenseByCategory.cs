namespace inventoryApi.Domain.Entities
{
    public class ExpenseByCategory
    {
        public Guid ExpenseByCategoryId {get;set;}
        public Guid ExpenseSummaryid {get;set;}
        public DateTime DateCreated {get;set;}
        public string Category {get;set;}
        public double Amount {get;set;}
    }
}