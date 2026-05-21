# ☕ Coffee Shop Management System
### Complete Windows Forms App | C# | .NET 8 | SQLite | BCrypt

---

## 📋 QUICK START (Step by Step)

### Step 1 — Required Software
- **Visual Studio 2022** (Community or higher)
  - Workload: `.NET desktop development`
- **.NET 6 SDK** — https://dotnet.microsoft.com/download/dotnet/6.0
- **DB Browser for SQLite** (optional, for DB inspection)
  - https://sqlitebrowser.org/dl/

---

### Step 2 — Open Project
1. Extract the ZIP
2. Open `CoffeeShopMS.sln` in Visual Studio 2022
3. Wait for solution to load

---

### Step 3 — Restore NuGet Packages
Visual Studio will auto-restore packages on build.
To do it manually:

**Option A — Visual Studio:**
```
Tools → NuGet Package Manager → Package Manager Console
PM> Update-Package -reinstall
```

**Option B — Command Line (in project folder):**
```bash
dotnet restore
```

**Packages used:**
| Package | Version | Purpose |
|---------|---------|---------|
| `System.Data.SQLite.Core` | 1.0.118 | SQLite database driver |
| `BCrypt.Net-Next` | 4.0.3 | Password hashing (security) |

---

### Step 4 — Build & Run
```
Press F5  (or Ctrl+F5 to run without debugging)
```

✅ The app will:
- Auto-create `CoffeeShop.db` in the output folder
- Auto-create all tables (Users, Products, Orders, OrderDetails)
- Seed 1 admin account + 10 sample products

---

## 🔐 Default Login
| Field | Value |
|-------|-------|
| Username | `admin` |
| Password | `admin123` |

> Password is stored as BCrypt hash — never plain text.

---

## 📁 Project Structure
```
CoffeeShopMS/
├── CoffeeShopMS.sln
└── CoffeeShopMS/
    ├── CoffeeShopMS.csproj
    ├── Program.cs
    ├── Database/
    │   └── DBHelper.cs          ← DB connection + table creation
    ├── Models/
    │   ├── User.cs
    │   ├── Product.cs
    │   └── Order.cs             ← Order + OrderDetail
    ├── Forms/
    │   ├── LoginForm.cs         ← Login logic
    │   ├── LoginForm.Designer.cs
    │   ├── LoginForm.resx
    │   ├── DashboardForm.cs     ← Navigation hub
    │   ├── DashboardForm.Designer.cs
    │   ├── DashboardForm.resx
    │   ├── ProductsForm.cs      ← Add/Edit/Delete products
    │   ├── ProductsForm.Designer.cs
    │   ├── ProductsForm.resx
    │   ├── OrdersForm.cs        ← Create orders + cart
    │   ├── OrdersForm.Designer.cs
    │   ├── OrdersForm.resx
    │   ├── BillingForm.cs       ← Order history + reprint bill
    │   ├── BillingForm.Designer.cs
    │   └── BillingForm.resx
    └── Properties/
        └── AssemblyInfo.cs
```

---

## 🗄️ Database Schema (SQLite)

```sql
-- Users table (BCrypt hashed passwords)
CREATE TABLE Users (
    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT    NOT NULL UNIQUE,
    Password TEXT    NOT NULL,
    Role     TEXT    NOT NULL DEFAULT 'Cashier'
);

-- Products table
CREATE TABLE Products (
    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
    Name     TEXT    NOT NULL,
    Category TEXT    NOT NULL,
    Price    REAL    NOT NULL,
    Stock    INTEGER NOT NULL DEFAULT 0
);

-- Orders table
CREATE TABLE Orders (
    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderDate    TEXT    NOT NULL,
    CustomerName TEXT    NOT NULL DEFAULT 'Walk-in',
    TotalAmount  REAL    NOT NULL DEFAULT 0,
    Status       TEXT    NOT NULL DEFAULT 'Completed'
);

-- Order line items
CREATE TABLE OrderDetails (
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderId   INTEGER NOT NULL,
    ProductId INTEGER NOT NULL,
    Quantity  INTEGER NOT NULL,
    UnitPrice REAL    NOT NULL,
    Subtotal  REAL    NOT NULL,
    FOREIGN KEY (OrderId)   REFERENCES Orders(Id),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
```

---

## 🧩 Module Guide (Viva Friendly)

### Login Module
- BCrypt.Verify() compares entered password with stored hash
- Never stores or compares plain text passwords

### Dashboard Module
- Sidebar navigation using Panel + Buttons
- Child forms open inside `pnlContent` (MDI-style without MDI container)

### Products Module
- Full CRUD: Add / Update / Delete
- Click a row → fields auto-fill for editing
- Live search filter

### Orders Module
- Cart system using `List<OrderDetail>`
- Stock validation before adding to cart
- Places order → inserts to Orders + OrderDetails → reduces stock

### Billing Module
- Date range filter for order history
- Click any order → see its line items below
- Re-print bill as text receipt

---

## 🔧 Troubleshooting

| Problem | Solution |
|---------|----------|
| NuGet packages missing | Right-click Solution → Restore NuGet Packages |
| `System.Data.SQLite` not found | Install via NuGet: `System.Data.SQLite.Core` |
| App crashes on start | Make sure output folder is writable (for .db file) |
| Design View shows error | Do NOT edit Designer.cs files manually |
| `BCrypt` namespace error | Install: `BCrypt.Net-Next` via NuGet |

---

## 💡 Architecture Notes
- **Separation of Concerns**: Each form has `.cs`, `.Designer.cs`, `.resx`
- **DBHelper**: Single class for all DB operations (no scattered connections)
- **Models**: Plain C# classes (POCO) — no framework dependency
- **Forms**: Business logic only in `.cs`, UI layout only in `.Designer.cs`
