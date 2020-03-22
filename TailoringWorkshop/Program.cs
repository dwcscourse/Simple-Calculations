using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double totalTablecloths = numberTables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double totalCarriage = numberTables * (length/2) * (length/2);

            double priceUDS = totalTablecloths * 7 + totalCarriage * 9;
            Console.WriteLine($"{priceUDS:f2} USD");
            Console.WriteLine($"{priceUDS * 1.85:f2} BGN");
        }
    }
}
