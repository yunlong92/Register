internal class Program
{
    private static void Main(string[] args)
    {
        string name = "";
        string salary = "";
        bool hasEmployee = false;

        while (true)
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till anställd");
            Console.WriteLine("2. Visa anställd");
            Console.WriteLine("3. Avsluta");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Ange namn på anställd: ");
                name = Console.ReadLine();

                Console.Write("Ange lön på anställd: ");
                salary = Console.ReadLine();

                hasEmployee = true;
                Console.WriteLine("Anställd tillagd.");
            }
            else if (choice == "2")
            {
                if (hasEmployee)
                {
                    Console.WriteLine($"Namn: {name}, Lön: {salary}");
                }
                else
                {
                    Console.WriteLine("Inga anställda i registret.");
                }
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }
        }
    }
}