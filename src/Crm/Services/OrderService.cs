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
        DateTime orderData,
        Delivery deliveryType,
        string addres
    )
    {
        return new()
        {
            OrderId = orderId,
            Description = description,
            Price = price,
            OrderData = orderData,
            DeliveryType = deliveryType,
            Addres =addres
        };
    }
}
}