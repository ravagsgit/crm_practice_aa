using Crm.Entities.DTOs;
using Crm.Entities;

namespace Crm.Services
{

public sealed class OrderService
{
    private readonly List<Order> orders = new List<Order>();
    public Order CreateOrder(OrderInfo orderInfo)
    {
        Order newOrder = new()
        {
            OrderId = orderInfo.Id,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Delivery = orderInfo.DeliveryType,
            OrderDate = orderInfo.OrderDate,
            Address =orderInfo.Address
        };
        orders.Add(newOrder);
        Console.WriteLine("New order was created successiful and added to list.");

        return newOrder;
    }

    public bool GetClient(int orderId, out Order? order)
    {
        foreach(var orderItem in orders)
        {
            if(orderItem.OrderId.Equals(orderId))
            {
                order = orderItem;
                return true;
            }
        }

        order = null;
        return false;
    }

}
}