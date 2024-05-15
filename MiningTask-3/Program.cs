namespace MiningTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();
            string resource = null;
            long quantity = 0;
            bool isResource = true;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                if (isResource)
                {
                    resource = input;
                    if (!resources.ContainsKey(resource))
                    {
                        resources[resource] = 0;
                    }
                }
                else
                {
                    quantity = long.Parse(input);
                    resources[resource] += quantity;
                }
                isResource = !isResource;
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
