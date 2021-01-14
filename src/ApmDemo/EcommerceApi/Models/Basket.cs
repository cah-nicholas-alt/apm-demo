using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Models
{
    public record Basket(string UserId, IEnumerable<int> ProductIds);
}
