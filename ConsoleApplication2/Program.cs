using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var output = "";
                output = GetOutput(i);

                Console.WriteLine(output);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        

        private static string GetOutput(int number)
        {
            var output = "";

            if (number % 3 == 0 && number % 5 == 0)
            {
                output = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                output = "Fizz";
            }
            else if (number % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = number.ToString();
            }
            return output;
        }
    }
}
