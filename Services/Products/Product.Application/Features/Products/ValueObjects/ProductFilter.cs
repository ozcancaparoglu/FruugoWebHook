namespace Product.Application.Features.Products.ValueObjects
{
    public class ProductFilter
    {
        public string type { get; set; }
        public List<string> status { get; set; }
    }
}
