using System.Globalization;

namespace Supermarket_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Product>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stocked")
                {
                    break;
                }
                string[] parts = input.Split(' ');
                string name = parts[0];
                decimal price = decimal.Parse(parts[1], CultureInfo.InvariantCulture);
                int quantity = int.Parse(parts[2]);
                if (products.ContainsKey(name))
                {
                    var product = products[name];
                    product.Quantity += quantity;
                    if (product.Price != price)
                    {
                        product.Price = price;
                    }
                }
                else
                {
                    products[name] = new Product(name, price, quantity);
                }
            }
            decimal grandTotal = 0;
            foreach (var product in products.Values)
            {
                decimal total = product.TotalPrice();
                Console.WriteLine($"{product.Name}: ${product.Price:F2} * {product.Quantity} = ${total:F2}");
                grandTotal += total;
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
