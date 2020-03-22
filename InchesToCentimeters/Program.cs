using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double InchesToCentimeters = inches * 2.54;
            Console.WriteLine(InchesToCentimeters);
        }
    }
}
