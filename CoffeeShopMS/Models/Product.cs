namespace CoffeeShopMS.Models;

/// <summary>
/// Represents a product in the coffee shop menu.
/// </summary>
public class Product
{
    public int    Id       { get; set; }
    public string Name     { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public double Price    { get; set; }
    public int    Stock    { get; set; }

    public override string ToString() => $"{Name} - Rs.{Price:F0}";
}
