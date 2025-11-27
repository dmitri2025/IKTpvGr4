namespace Kujundi_kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int roundRadius = 3;
            Console.WriteLine("Ruudu pindala: " + (2 * roundRadius) * (2 * roundRadius));
            Console.WriteLine("Ruudu ümbermõõt: " + (2 * roundRadius) * 4);

            int sqvareSide = roundRadius * 2;
            int squareArea = sqvareSide * sqvareSide;
            int squareperimetr = sqvareSide * 4;

            Console.WriteLine("Ruudu pindala: " + squareArea);
            Console.WriteLine("Ruudu ümbermõõt: " + squareperimetr);

            double circleArea = Math.PI * roundRadius * roundRadius;
            double circlePerimeter = 2 * Math.PI * roundRadius;

            Console.WriteLine($"Ringi pindala: {circleArea}");
            Console.WriteLine($"Ringi ümbermõõt: {circlePerimeter}");
        }
    }
}
