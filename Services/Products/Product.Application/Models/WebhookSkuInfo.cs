namespace Product.Application.Models
{
    public class WebhookSkuInfo
    {
        public string MerchantSkuId { get; set; }

        public string MerchantSkuQualityStatus { get; set; }

        public List<string> ValidationErrors { get; set; }
    }
}
