namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();

            switch (input) 
            {
                case "a":
                    Console.WriteLine("Sisestasid tähe a");
                    break;

                case "e":
                    Console.WriteLine("Sisestasid tähe e");
                    break;

                case "i":
                    Console.WriteLine("Sisestasid tähe i");
                    break;

                default:
                    Console.WriteLine("Ei ole vokaal");
                    break;
            }
        }
    }
} 
