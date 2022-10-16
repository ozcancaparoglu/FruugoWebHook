namespace Product.Application.Models
{
    public class WebhookPayload
    {
        public bool ProductCreated { get; set; }

        public bool ProductUpdated { get; set; }

        public List<WebhookSkuInfo> CreatedSkus { get; set; }

        public List<WebhookSkuInfo> UpdatedSkus { get; set; }
    }
}
