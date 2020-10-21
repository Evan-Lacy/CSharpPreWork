using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feels = Console.ReadLine();

            if (feels == "5")
            {
                Console.WriteLine("That's great to hear!");
            }
            else if (feels == "4")
            {
                Console.WriteLine("Good stuff. Have an Oreo");

            }
            else if (feels == "3")
            {
                Console.WriteLine("Hope things get better soon. Have a cookie!");

            }
            else if (feels == "2")
            {
                Console.WriteLine("Oh, I'm sorry to hear that bud. Have a beer.");

            }
            else if (feels == "1")
            {
                Console.WriteLine("Damn, I hope your day gets better. Have a shot");
            }
            else
            {
                Console.WriteLine("Sorry, out fission");

            }
            Console.ReadLine();

            //bool isOn = true;
            //bool isHot = false;

            //if (isOn)
            //{
            //    Console.WriteLine("The light is on, it's bright.");
            //}

            //if (isOn == true)
            //{
            //    Console.WriteLine("The light is on.");
            //}

            //if (isOn && isHot)
            //{
            //    Console.WriteLine("lights on and it's hot");
            //}

            //if (isOn || isHot)
            //{
            //    Console.WriteLine("lights on or it is hot");
            //}

            //if (!isHot)
            //{
            //    Console.WriteLine("it is not hot");
            //}

        }
    }
}
