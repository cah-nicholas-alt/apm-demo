using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Data;
using EcommerceApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly EcommerceDbContext _ecommerceDbContext;

        public CheckoutController(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Basket basket)
        {
            var products = await _ecommerceDbContext.Products
                .Where(p => basket.ProductIds.Contains(p.ProductId))
                .ToListAsync();

            var sum = basket.ProductIds.Sum(i => products.First(p => p.ProductId == i).Cost);
            _ecommerceDbContext.Orders.Add(new Order(0, sum, sum * .07m, sum * 1.07m, basket.UserId));
            await _ecommerceDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
