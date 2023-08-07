using System;
namespace Crm.Entities
{
public sealed class Order
{
    public int OrderId{get;set;}
    public string Description{get;set;}
    public int Price{get;set;}
    public DateTime OrderData{get;set;}
    public Delivery DeliveryType{get;set;}
    public string Addres{get;set;}

}
}