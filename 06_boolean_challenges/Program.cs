using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 150 / 100;

            //if (value == 1)
            //{
            //    Console.WriteLine(true + " 1");
            //} else
            //{
            //    Console.WriteLine(false + " 1"); 
            //}
            //Console.WriteLine(value);

            //double value2 = 150d / 100;

            //if (value2 == 1)
            //{
            //    Console.WriteLine(true + " 2");
            //}
            //else
            //{
            //    Console.WriteLine(false + " 2");
            //}
            //Console.WriteLine(value2);
            //This works because the value2 is initialized as a double
            //and one of the operands is cast as a double through the 'd' flag.

            double amt = 45.37;
            bool trigger = false;

            Console.WriteLine("Good morning, Dave. Please guess what decimal I am thinking of. " +
                "It is between 1 and 50.");
            double input = Convert.ToDouble(Console.ReadLine());
            while (trigger == false){
                if (input == amt)
                {
                    Console.WriteLine("Excellent guess, Dave.");
                    trigger = true;
                }
                else if (input >= amt)
                {
                    Console.WriteLine("Might I suggest a lower value?");
                    input = Convert.ToDouble(Console.ReadLine());
                } else if (input <= amt)
                {
                    Console.WriteLine("Perhaps a higher value this time?");
                    input = Convert.ToDouble(Console.ReadLine());
                }

            }
        }
    }
}
