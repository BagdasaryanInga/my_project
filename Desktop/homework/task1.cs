using System;
namespace project { 
class program
{
    static void Main(string[] arg)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        Console.WriteLine("Enter value for a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for b:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for c:");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for d:");
        d = Convert.ToInt32(Console.ReadLine());
         if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        Console.WriteLine("A is minimal : " + a);
                    }
                    else
                    {
                        Console.WriteLine("D is minimal : " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("C is minimal : " + c);
                    }
                    else
                    {
                        Console.WriteLine("D is minimal : " + d);
                    }
                }
            }
            else
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        Console.WriteLine("B is minimal : " + b);
                    }
                    else
                    {
                        Console.WriteLine("D is minimal : " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("D is minimal : " + c);
                    }
                    else
                    {
                        Console.WriteLine("D is minimal : " + d);
                    }
                    Console.ReadKey();
                }
            }
                



    }
}
          }