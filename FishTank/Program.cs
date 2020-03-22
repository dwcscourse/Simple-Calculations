using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageOthers = double.Parse(Console.ReadLine());

            double volumeInLitres = (length * width * height) * 0.001;
            double litresOfOthers = volumeInLitres * percentageOthers * 0.01;


            Console.WriteLine("{0:F3}", volumeInLitres - litresOfOthers);
        }
    }
}
