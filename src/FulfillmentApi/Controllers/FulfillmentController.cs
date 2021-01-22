using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FulfillmentApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FulfillmentApi.Controllers
{
    [Route("/api/{controller}/")]
    [ApiController]
    public class FulfillmentController : ControllerBase
    {
        private readonly FulfillmentDbContext _fulfillmentContext;
        private readonly ILogger<FulfillmentDbContext> _logger;

        public FulfillmentController(FulfillmentDbContext fulfillmentContext, ILogger<FulfillmentDbContext> logger)
        {
            _fulfillmentContext = fulfillmentContext;
            _logger = logger;
        }
        
        [HttpGet("{orderId}/status")]
        public async Task<IActionResult> GetFulfillmentStats(int orderId)
        {
            _logger.LogInformation("Info");
            _logger.LogWarning("Warning");
            _logger.LogError("Error");

            var orderItem = await _fulfillmentContext.OrderItems.FindAsync(orderId);
            var status = orderItem.Status;
            return Ok(status);
        }
        
        [HttpGet("")]
        public async Task<IActionResult> GetFulfillmentsByStatus([FromQuery] IEnumerable<string> statuses)
        {
            var orderItems = await _fulfillmentContext.OrderItems
                .Where(o => statuses.Contains(o.Status)).ToListAsync();
            
            return Ok(orderItems);
        }
    }
}