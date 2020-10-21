using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Loops_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int result = 1; result <= 100; result++) {

                bool fizz = result % 3 == 0;
                bool buzz = result % 5 == 0;
                
                if(fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (fizz)
                {
                    Console.WriteLine("Fizz");
                } else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(result);
                }

            }
        }
    }
}
