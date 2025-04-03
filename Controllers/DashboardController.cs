
using inventoryApi.Domain.Contracts;
using inventoryApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace inventoryApi.Controllers
{
    [Route("/dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        [HttpGet("/metrics")]
        public async Task<ActionResult<MetricResponse>> GetMetrics()
        {
            var response = await _dashboardService.GetDashboardMetrics();
            return Ok(response);
        }

    }

}