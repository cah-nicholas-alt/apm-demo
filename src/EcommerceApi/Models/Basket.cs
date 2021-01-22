using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public record Basket(string UserId, IEnumerable<int> ProductIds);
}
