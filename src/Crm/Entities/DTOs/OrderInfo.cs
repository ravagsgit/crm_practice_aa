namespace Crm.Entities.DTOs;

public readonly struct OrderInfo
{
    public int Id { get; init; }
    public string Description { get; init; }
    public decimal Price { get; init; }
    public DateTime OrderDate { get; init; }
    public Delivery DeliveryType { get; init; }
    public string Address { get; init; }
}