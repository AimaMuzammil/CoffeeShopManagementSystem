using System.Data.SQLite;

namespace CoffeeShopMS.Database;

/// <summary>
/// DBHelper: Handles all database connection and initialization logic.
/// Clean Architecture: Single Responsibility - only DB concerns here.
/// </summary>
public static class DBHelper
{
    // Database file path (placed next to the executable)
    private static readonly string DbPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "CoffeeShop.db");

    public static string ConnectionString => $"Data Source={DbPath};Version=3;";

    /// <summary>
    /// Returns an open SQLite connection. Caller must dispose it.
    /// </summary>
    public static SQLiteConnection GetConnection()
    {
        var conn = new SQLiteConnection(ConnectionString);
        conn.Open();
        return conn;
    }

    /// <summary>
    /// Creates all tables if they don't exist, and seeds a default admin user.
    /// Called once at application startup.
    /// </summary>
    public static void InitializeDatabase()
    {
        using var conn = GetConnection();
        using var cmd = conn.CreateCommand();

        // ── Users Table ──────────────────────────────────────────────────────
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT    NOT NULL UNIQUE,
                Password TEXT    NOT NULL,   -- BCrypt hash
                Role     TEXT    NOT NULL DEFAULT 'Cashier'
            );";
        cmd.ExecuteNonQuery();

        // ── Products Table ───────────────────────────────────────────────────
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS Products (
                Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                Name     TEXT    NOT NULL,
                Category TEXT    NOT NULL,
                Price    REAL    NOT NULL,
                Stock    INTEGER NOT NULL DEFAULT 0
            );";
        cmd.ExecuteNonQuery();

        // ── Orders Table ─────────────────────────────────────────────────────
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS Orders (
                Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                OrderDate   TEXT    NOT NULL,
                CustomerName TEXT   NOT NULL DEFAULT 'Walk-in',
                TotalAmount REAL    NOT NULL DEFAULT 0,
                Status      TEXT    NOT NULL DEFAULT 'Completed'
            );";
        cmd.ExecuteNonQuery();

        // ── OrderDetails Table ───────────────────────────────────────────────
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS OrderDetails (
                Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                OrderId   INTEGER NOT NULL,
                ProductId INTEGER NOT NULL,
                Quantity  INTEGER NOT NULL,
                UnitPrice REAL    NOT NULL,
                Subtotal  REAL    NOT NULL,
                FOREIGN KEY (OrderId)   REFERENCES Orders(Id),
                FOREIGN KEY (ProductId) REFERENCES Products(Id)
            );";
        cmd.ExecuteNonQuery();

        // ── Seed default admin if no users exist ─────────────────────────────
        cmd.CommandText = "SELECT COUNT(*) FROM Users;";
        long userCount = (long)(cmd.ExecuteScalar() ?? 0L);

        if (userCount == 0)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword("admin123");
            cmd.CommandText = @"
                INSERT INTO Users (Username, Password, Role)
                VALUES ('admin', @pwd, 'Admin');";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pwd", hashedPassword);
            cmd.ExecuteNonQuery();

            // Seed some sample products
            SeedProducts(conn);
        }
    }

    private static void SeedProducts(SQLiteConnection conn)
    {
        using var cmd = conn.CreateCommand();
        var products = new[]
        {
            ("Espresso",    "Coffee",    250.0, 100),
            ("Cappuccino",  "Coffee",    350.0, 100),
            ("Latte",       "Coffee",    320.0, 100),
            ("Americano",   "Coffee",    280.0, 100),
            ("Cold Brew",   "Coffee",    380.0,  80),
            ("Green Tea",   "Tea",       200.0, 100),
            ("Chai Latte",  "Tea",       270.0, 100),
            ("Croissant",   "Food",      180.0,  50),
            ("Muffin",      "Food",      150.0,  50),
            ("Cheesecake",  "Food",      280.0,  30),
        };

        foreach (var (name, cat, price, stock) in products)
        {
            cmd.CommandText = @"
                INSERT INTO Products (Name, Category, Price, Stock)
                VALUES (@n, @c, @p, @s);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@c", cat);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@s", stock);
            cmd.ExecuteNonQuery();
        }
    }
}
