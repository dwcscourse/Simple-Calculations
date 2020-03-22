using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectionars = int.Parse(Console.ReadLine());
            int qCake = int.Parse(Console.ReadLine());
            int qGofrets = int.Parse(Console.ReadLine());
            int qPancakes = int.Parse(Console.ReadLine());

            int totalCake = days * confectionars * qCake;
            int totalGofrets = days * confectionars * qGofrets;
            int totalPancake = days * confectionars * qPancakes;

            double totalPrice = (totalCake * 45.00) + (totalGofrets * 5.80) + (totalPancake * 3.20);


            Console.WriteLine($"{totalPrice - (totalPrice/8):f2}");
        }
    }
}
