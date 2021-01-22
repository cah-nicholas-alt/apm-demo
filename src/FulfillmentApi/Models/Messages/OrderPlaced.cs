using System.Collections.Generic;

namespace FulfillmentApi.Models.Messages
{
    public record OrderPlaced(int OrderId, IEnumerable<int> ProductIds);
}
