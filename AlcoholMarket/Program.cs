using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerVolume = double.Parse(Console.ReadLine());
            double wineVolume = double.Parse(Console.ReadLine());
            double rakiaVolume = double.Parse(Console.ReadLine());
            double whiskeyVolume = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.40);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80);

            double beerAmount = beerPrice * beerVolume;
            double wineAmount = winePrice * wineVolume;
            double rakiaAmount = rakiaPrice * rakiaVolume;
            double whiskeyAmount = whiskeyPrice * whiskeyVolume;

            double totalPrice = beerAmount + wineAmount + rakiaAmount + whiskeyAmount;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
