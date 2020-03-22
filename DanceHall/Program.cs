using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double hallArea = (L * 100) * (W * 100);
            double wardrobeArea = ((a*100)*(a*100));
            double benchArea = hallArea / 10;

            double freeSpace = hallArea - wardrobeArea - benchArea;

            Console.WriteLine($"{Math.Floor(freeSpace / 7040)}");
        }
    }
}
