using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulfillmentApi.Models
{
    public record OrderItem(int OrderItemId, int OrderNo, int ProductId, string Status);
}
