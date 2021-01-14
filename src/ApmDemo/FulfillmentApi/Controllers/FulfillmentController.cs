using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FulfillmentApi
{
    [Route("/api/{controller}/")]
    [ApiController]
    public class FulFillmentController : ControllerBase
    {
        [HttpGet("{id}/status")]
        public Task GetFullfillmentStats(string orderId)
        {
            return Task.CompletedTask;
        }
        
        [HttpGet("")]
        public Task GetFulfillmentsByStatus([FromQuery] IEnumerable<int> statusIds)
        {
            return Task.CompletedTask;
        }
    }
}