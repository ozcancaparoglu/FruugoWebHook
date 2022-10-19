namespace Product.Application.Features.Products.ValueObjects
{
    public class SkuFilter
    {
        public string productId { get; set; }
        public List<string> skuIds { get; set; }
    }
}
