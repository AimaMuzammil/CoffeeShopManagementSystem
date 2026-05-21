using CoffeeShopMS.Database;
using CoffeeShopMS.Forms;

namespace CoffeeShopMS;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Initialize database (create tables if not exist)
        DBHelper.InitializeDatabase();

        // Open Login Form
        Application.Run(new LoginForm());
    }
}
