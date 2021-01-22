namespace FulfillmentApi.Models
{
    public record OrderItem(int OrderItemId, int OrderNo, int ProductId, string Status);
}
