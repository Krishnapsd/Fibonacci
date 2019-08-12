using System;

namespace FibonacciHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Number");
            int firstVal, secondVal, thirdVal, terms;
            firstVal = 0;
            secondVal = 1;
            Console.WriteLine();
            Console.Write("Enter the last position: ");
            terms = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstVal + "  " + secondVal);
           for(int i=3;i<=terms;i++)
           
            {
                thirdVal = firstVal + secondVal;
                Console.Write("  " + thirdVal);
                firstVal = secondVal;
                secondVal = thirdVal;
            }
            Console.ReadLine();
        }
    }
}
