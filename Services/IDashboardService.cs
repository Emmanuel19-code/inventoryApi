using inventoryApi.Domain.Contracts;

namespace inventoryApi.Services
{
    public interface IDashboardService
    {
        Task<MetricResponse> GetDashboardMetrics();
    }
}