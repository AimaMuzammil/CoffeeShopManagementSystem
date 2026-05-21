namespace CoffeeShopMS.Models;

/// <summary>
/// Represents a system user (Admin or Cashier).
/// </summary>
public class User
{
    public int    Id       { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // BCrypt hash
    public string Role     { get; set; } = "Cashier";
}
