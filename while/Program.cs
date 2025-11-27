namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 1;

            while (a <= 5) 
            {
                int b = 1;
                while (b <= 1)
                {
                Console.Write(b + " ");
                b++;
                }

                Console.WriteLine();
                a++;
            } 
        }
    }
}
