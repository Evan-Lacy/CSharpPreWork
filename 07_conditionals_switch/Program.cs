using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name, solder?!");
            string inputName = Console.ReadLine();

            switch (inputName)
            {
                case "Sierra":
                    Console.WriteLine("Sierra is a doll collector.");
                    break;

                case "Alyssa":
                    Console.WriteLine("Aly is a soft and sweet girl.");
                    break;

                case "Tael":
                    Console.WriteLine("Tael is the best NB around, and nothing's gonna ever keep them down.");
                    break;

                case "Evan":
                    Console.WriteLine("Welcome back, Sir");
                    break;

            }
        }
    }
}
