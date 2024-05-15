namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] parts = input.Split(' ');
                string command = parts[0];
                string name = parts[1];
                if (command == "A")
                {
                    string phoneNumber = parts[2];
                    phoneBook[name] = phoneNumber; 
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
