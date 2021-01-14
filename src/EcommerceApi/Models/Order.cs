using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Models
{
    public record Order(int OrderId, decimal OrderTotal, decimal Taxes, decimal GrandTotal, string UserId);
}
