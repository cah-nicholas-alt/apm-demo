using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Models
{
    public record Product(int ProductId, string ProductName, decimal Cost);
}
