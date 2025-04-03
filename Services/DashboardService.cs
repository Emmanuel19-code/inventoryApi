
using inventoryApi.Domain.Contracts;
using inventoryApi.Infrastruture.Context;
using Microsoft.EntityFrameworkCore;

namespace inventoryApi.Services
{
    public class DashboardServcie : IDashboardService
    {
        private readonly ApplicationDbContext _dbContext;
        public DashboardServcie(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<MetricResponse> GetDashboardMetrics()
        {
            try
            {
                var popularProducts =await _dbContext.Products.OrderByDescending(p=>p.StockQuantity).Take(15).ToListAsync();
                var salesSummary = await _dbContext.SalesSummary.OrderByDescending(p=>p.DateCreated).Take(5).ToListAsync();
                var purchaseSummary =await _dbContext.PurchaseSummary.OrderByDescending(p=>p.DateCreated).Take(5).ToListAsync();
                var expenseSummary =await _dbContext.ExpenseSummary.OrderByDescending(e=>e.DateCreated).Take(5).ToListAsync();
                var expenseCategory  =await _dbContext.ExpenseByCategory.OrderByDescending(e=>e.DateCreated).Take(5).ToListAsync();
                var response = new  MetricResponse
                {
                    PopularProducts = popularProducts,
                    SalesSummaries= salesSummary,
                    ExpenseSummaries = expenseSummary,
                    PurchaseSummaries = purchaseSummary,
                    ExpenseByCategories = expenseCategory

                };
                return response;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}