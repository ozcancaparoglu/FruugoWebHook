namespace Product.Application.Features.Products.Commons
{
    public class FruugoBaseCommand
    {
        //public string Type { get; set; }

        public object Payload { get; set; }  //IDictionary<string, object> Payload { get; set; } = new Dictionary<string, object>();

        public int MerchantId { get; set; }

        public string CorrelationId { get; set; }
    }
}
