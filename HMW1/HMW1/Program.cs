using System.Globalization;

namespace HMW1;

record Product(string Name, decimal Price);
record Order(int OrderNumber, string Client, Product Product, string Address);

static class Program
{

    static string ReadNonEmptyString(string prompt, bool allowExit = false)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (input is null)
            {
                Console.WriteLine();
                Console.Write("Empty input. Exiting");
                Environment.Exit(0);
            }
            input = input.Trim();
            if (allowExit && input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                return input;

            if (!string.IsNullOrWhiteSpace(input))
                return input;
            
            Console.WriteLine("Value cannot be empty. Please enter a valid value.");
        }
    }

    static decimal ReadDecimal(string prompt)
    {
        var styles = NumberStyles.Float | NumberStyles.AllowThousands;

        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            
            if (input is null)
            {
                Console.WriteLine();
                Console.Write("Empty input. Exiting");
                Environment.Exit(0);
            }
            
            input = input.Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Value cannot be empty. Please enter a valid price.");
                continue;
            }

            if (decimal.TryParse(input, styles, CultureInfo.CurrentCulture, out var result))
            {
                if (result < 0)
                {
                    Console.WriteLine("Price cannot be negative. Please enter a non-negative number.");
                    continue;
                }
                return result;
            } 
            
            var normalized = input.Replace(",", ".");
            if (decimal.TryParse(normalized, styles, CultureInfo.InvariantCulture, out result))
            {
                if (result < 0)
                {
                    Console.WriteLine("Price cannot be negative. Please enter a non-negative number.");
                    continue;
                }
                return result;
            }
            
            Console.WriteLine("Invalid price format. Please enter a valid price (e.g., 19.99 or 19,99).");
        }
    }

    static void FormOrder(IList<Order> orders)
    {
        string client = ReadNonEmptyString("Client name: ");

        string productName = ReadNonEmptyString("Product name: ");
        
        decimal productPrice = ReadDecimal("Product price: ");
            
        string address = ReadNonEmptyString("Address: ");
            
        int orderNumber = orders.Count + 1;
        orders.Add(new Order(orderNumber, client, new Product(productName, productPrice), address));
    }

    static void Main()
    {
        var orders = new List<Order>();

        while (true)
        {
            Console.Write("Type 'exit' to exit, type 'order' to continue, type 'show' to see the formed orders: ");
            string menuInput = (Console.ReadLine() ?? string.Empty).Trim();
                switch (menuInput) {
                    case "exit":
                        return;
                    case "order":
                        FormOrder(orders);
                        continue;
                    case "show":
                        if (orders.Count <= 0)
                        {
                            Console.WriteLine("No orders have been formed yet.");
                            break;
                        }
                        foreach (var order in orders)
                        {
                            Console.WriteLine($"Order No {order.OrderNumber}");
                            Console.WriteLine($"Client: {order.Client}.");
                            Console.WriteLine($"Product: {order.Product.Name}, price {order.Product.Price:0.00} EUR.");
                            Console.WriteLine($"Address: {order.Address}.");
                            Console.WriteLine();
                        }
                        continue;
                    default:
                        Console.WriteLine("Invalid input. Please enter 'exit', 'enter', or 'show'.");
                        continue;
                }
        }
    }
}