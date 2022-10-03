using System;
namespace project
{
    class program
    {
        static void Main()
        {
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            double length = 0;
            Console.WriteLine("We are going to calculate length of vector.");
            Console.WriteLine("Enter value for x1 : ");
             x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for y1 : ");
             y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for x2 : ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for y2 : ");
            y2 = Convert.ToDouble(Console.ReadLine());
            length = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            Console.WriteLine("length of vector = " + length);
            Console.ReadKey();

        }
    }
}