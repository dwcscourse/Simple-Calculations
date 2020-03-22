using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double totalPrice = area * 7.61;
            double discount = totalPrice * 0.18;
            double finalPrice = totalPrice - discount;

            Console.WriteLine("The final price is: {0:F2} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);
        }
    }
}
