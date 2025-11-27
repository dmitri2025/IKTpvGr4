namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            {
                double muendiDiameeterMm = 25.75;

                double maaRaadiusMm = 6371e3 * 1000;

                double maaUmbermootMm = 2 * Math.PI * maaRaadiusMm;

                double muunteKokku = maaUmbermootMm / muendiDiameeterMm;

                Console.WriteLine($"Maa ümbermõõt: {maaUmbermootMm:n0} mm");
                Console.WriteLine($"Mündid mahuksid ümber Maa: {muunteKokku:n0}");
            }
        }

    } 
}
