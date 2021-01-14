using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Models.Messages
{
    public record OrderPlaced(int OrderId, IEnumerable<int> ProductIds);
}
