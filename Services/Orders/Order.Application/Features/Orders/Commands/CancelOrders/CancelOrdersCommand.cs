using System;
using MediatR;

namespace Order.Application.Features.Orders.Commands.CancelOrders
{
	public class CancelOrdersCommand : IRequest<string>
	{
        public List<Order> orders { get; set; }
    }
    public class ItemQuantity
    {
        public string productId { get; set; }
        public string skuId { get; set; }
        public int quantity { get; set; }
    }

    public class Order
    {
        public string type { get; set; }
        public string orderId { get; set; }
        public List<ItemQuantity> itemQuantities { get; set; }
        public string messageToCustomer { get; set; }
        public string messageToFruugo { get; set; }
        public string cancellationReason { get; set; }
    }
}

