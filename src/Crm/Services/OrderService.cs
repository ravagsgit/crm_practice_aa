using Crm.Entities.DTOs;
using Crm.Entities;
using Crm.interfaces;

namespace Crm.Services
{

public sealed class OrderService: IOrderService
{
    private readonly List<Order> _orders = new List<Order>();
    /// <summary>
    /// Create Order
    /// </summary>
    /// <param name="orderInfo"></param>
    /// <returns></returns>
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
        _orders.Add(newOrder);
        Console.WriteLine("New order was created successiful and added to list.");

        return newOrder;
    }

    /// <summary>
    /// Return Order by Id
    /// </summary>
    /// <param name="orderId"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool GetOrder(int orderId, out Order? order)
    {
        foreach(var orderItem in _orders)
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

    /// <summary>
    /// Return Order by description
    /// </summary>
    /// <param name="description"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool GetOrder(string description, out Order? order)
    {
        foreach(var orderItem in _orders)
        {
            if(orderItem.Description.Equals(description))
            {
                order = orderItem;
                return true;
            }
        }

        order = null;
        return false;
    }


    /// <summary>
    /// For editing order via description
    /// </summary>
    /// <param name="description"></param>
    /// <param name="newDescription"></param>
    public bool EditOrder(string description, string newDescription, out Order? order)
    {
        //Order order = null;
        bool result = GetOrder(description,out order);
        if(result)
        {
            order.Description = newDescription;
        }
        return result;
        
    }

    /// <summary>
    /// For editing order via Id
    /// </summary>
    /// <param name="orderId"></param>
    /// <param name="newDescription"></param>
    public bool EditOrder(int orderId, string newDescription, out Order? order)
    {
        //Order order = null;
        bool result = GetOrder(orderId,out order);
        if(result)
        {
            order.Description = newDescription;
        }
        return result;
        
    }

    /// <summary>
    /// Removing order by Id
    /// </summary>
    /// <param name="orderId"></param>
    public bool RemoveOrder(int orderId)
    {
        Order order = null;
        bool result = GetOrder(orderId,out order);
        if(result)
        _orders.Remove(order);  
        return result;     
        
    }

    /// <summary>
    /// Remove order by descriprion
    /// </summary>
    /// <param name="orderDescriprion"></param>
    public bool RemoveOrder(string orderDescriprion)
    {
        Order order = null;
        bool result = GetOrder(orderDescriprion,out order);
        if(result)
        _orders.Remove(order);  
        return result;        
        
    }
    

    public bool IsOrderListNotEmpty()
    {
        return _orders.Count>0;
    } 

}
}