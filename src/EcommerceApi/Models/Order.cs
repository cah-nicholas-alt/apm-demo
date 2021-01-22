namespace EcommerceApi.Models
{
    public record Order(int OrderId, decimal OrderTotal, decimal Taxes, decimal GrandTotal, string UserId);
}
