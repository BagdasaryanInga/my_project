using System;
namespace project
{
    class program
    {
        static void Main()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Enter value for a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = Convert.ToDouble(Console.ReadLine());
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("square: " + S);
            Console.ReadLine();
        }
    }
}
