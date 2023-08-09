using Crm.Entities.DTOs;
using Crm.Entities;

namespace Crm.Services
{

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
    {
        return new()
        {
            OrderId = orderInfo.Id,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            DeliveryType = orderInfo.DeliveryType,
            OrderDate = orderInfo.OrderDate,
            Address =orderInfo.Address
        };
    }
}
}