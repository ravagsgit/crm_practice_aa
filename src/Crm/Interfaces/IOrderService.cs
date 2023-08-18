namespace Crm.interfaces;

using Crm.Entities;
using Crm.Entities.DTOs;

public interface IOrderService
{
    Order CreateOrder(OrderInfo orderInfo);
    bool GetOrder(string description, out Order? order);
    bool GetOrder(int orderID, out Order? order);
}