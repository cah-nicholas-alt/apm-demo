using System.Collections.Generic;

namespace EcommerceApi.Models.Messages
{
    public record OrderPlaced(int OrderId, IEnumerable<int> ProductIds);
}
