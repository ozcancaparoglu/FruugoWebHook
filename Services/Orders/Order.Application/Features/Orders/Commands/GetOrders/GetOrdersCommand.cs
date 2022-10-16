using MediatR;
using Order.Application.Features.Orders.Commons;

namespace Order.Application.Features.Orders.Commands.GetOrders
{
    public class GetOrdersCommand : IRequest<string>
    {
        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }
        public string orderId { get; set; }
        public string productId { get; set; }
        public string skuId { get; set; }
        public List<string> statuses { get; set; }
        public List<string> customerCountries { get; set; }
        public int paymentAmountMin { get; set; }
        public int paymentAmountMax { get; set; }
    }
}
