using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg1 = "The cars we sell are ";
            string msg2 = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(msg1 + msg2);
            //concatenation

            //result: The cars we sell are BMW, Lexus, and Mercedes.

            string first = "Jenn";
            string last = "Williams";
            //composite formatting

            Console.WriteLine("Her name is {0} {1}.", first, last);

            //result: Her name is Jenn Williams.

            string firstName = "Robert";
            string lastName = "Paulsen";
            //1                 //2 //string interpolation
            Console.WriteLine($"His name is {firstName} {lastName}");
        }
    }
}
