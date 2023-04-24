using System;
using MediatR;

namespace Order.Application.Features.Orders.Queries
{
	public class GetOrderShipmentsQuery : IRequest<string>
	{
        public List<OrderShipment> orderShipments { get; set; }
    }
    public class OrderShipment
    {
        public string orderId { get; set; }
        public int shipmentId { get; set; }
    }
}

