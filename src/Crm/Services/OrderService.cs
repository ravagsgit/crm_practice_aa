using System;
using Crm.Entities;

namespace Crm.Services
{

public sealed class OrderService
{
    public Order CreateOrder(
        int orderId,
        string description,
        int price,
        Delivery delivery,
        DateTime orderData,
        string addres
    )
    {
        return new()
        {
            OrderId = orderId,
            Description = description,
            Price = price,
            DeliveryType = delivery,
            OrderDate = orderData,
            Address =addres
        };
    }
}
}