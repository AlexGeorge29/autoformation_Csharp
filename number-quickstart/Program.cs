using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
        }

        static void WorkingWithFloat()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a  + b) / c;
            Console.WriteLine(d);
        }
        static void Main(string[] args)
        {
            //WorkingWithIntegers();
            //int max = int.MaxValue;
            //int min = int.MinValue;
            //Console.WriteLine($"The range of integers is {min} to {max}");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            //WorkingWithFloat();
        }
    }
}