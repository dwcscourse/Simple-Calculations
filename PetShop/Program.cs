using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());

            double sum = (numberOfDogs * 2.5) + (numberOfOtherAnimals * 4);
            Console.WriteLine("{0:F2} lv.", sum);
        }
    }
}
