using System;
namespace Crm.Entities
{
public sealed class Order
{
     private string? _description;
    private decimal _price;
    private DateTime? _orderDate;
    private Delivery? _delivery;
    private string? _address;

    public int OrderId { get; set; }

    public required string Description
    {
        get => _description ?? string.Empty;
        init => _description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public required decimal Price
    {
        get => _price;
        init => _price = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public required DateTime? OrderDate
    {
        get => _orderDate ?? null;
        init => _orderDate = value is not null ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public required Delivery? Delivery
    {
        get => _delivery ?? null;
        init => _delivery = value is not null ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public required string? Address
    {
        get => _address ?? string.Empty;
        init => _address = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

}
}