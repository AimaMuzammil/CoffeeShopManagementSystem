namespace CoffeeShopMS.Models;

/// <summary>
/// Represents a customer order header.
/// </summary>
public class Order
{
    public int      Id           { get; set; }
    public string   OrderDate    { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    public string   CustomerName { get; set; } = "Walk-in";
    public double   TotalAmount  { get; set; }
    public string   Status       { get; set; } = "Completed";

    public List<OrderDetail> Details { get; set; } = new();
}

/// <summary>
/// Represents a line item within an order.
/// </summary>
public class OrderDetail
{
    public int    Id        { get; set; }
    public int    OrderId   { get; set; }
    public int    ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int    Quantity  { get; set; }
    public double UnitPrice { get; set; }
    public double Subtotal  => Quantity * UnitPrice;
}
