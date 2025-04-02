namespace inventoryApi.Domain.Entities
{
    public class ExpenseSummary
    {
        public Guid ExpenseSummaryid {get;set;}
        public double TotalExpenses {get;set;}
        public DateTime DateCreated {get;set;}
    }
}