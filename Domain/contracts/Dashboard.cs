using inventoryApi.Domain.Entities;

namespace inventoryApi.Domain.Contracts
{
    public class MetricResponse
    {
        public List<Products> PopularProducts {get;set;}
        public List<SalesSummary> SalesSummaries {get;set;}
        public List<ExpenseSummary> ExpenseSummaries {get;set;}
        public List<PurchaseSummary> PurchaseSummaries {get;set;}
        public List<ExpenseByCategory> ExpenseByCategories {get;set;}
    }
}