using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //build program that loops from 1 to 100
            //if number is divisible by 3 print Fizz
            //if number is divisible by 5 print Buzz
            //if divisible by both print FizzBuzz
            //otherwise print number

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
