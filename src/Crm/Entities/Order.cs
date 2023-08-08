using System;
namespace Crm.Entities
{
public sealed class Order
{
    public int OrderId{get;set;}
    public string Description{get;set;}
    public int Price{get;set;}
    public Delivery DeliveryType{get;set;}
    public DateTime OrderDate{get;set;}
    public string Address{get;set;}

}
}