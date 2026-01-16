namespace ConsoleApp1212112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option");
            Console.WriteLine("1. ristküliku");
            Console.WriteLine("2. püramiidi");
            Console.WriteLine("3. DS");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                ForLoop();
            }
            else if (option == 2)
            {
                SecondOp();
            }
            else if (option == 3)
            {
                ThirdOp();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        static void ForLoop()
        {
            Console.WriteLine("Sisesta pikkus");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta laius");
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            int S = row * col;
            int P = 2 * (row + col);
            Console.WriteLine("Pindala on " + S);
            Console.WriteLine("Ümbermõõt on " + P);
        }
        static void SecondOp()
        {
            int i, j, n;

            Console.Write("Loo romb tärnidest: \n");
            Console.Write("----------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta rombi suurus");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n - 0; i >= 0; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void ThirdOp()
        {
            Console.Write("Sisesta a väärtus ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b väärtus ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c väärtus ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, " +
                $"x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
        }
    }
}

      
