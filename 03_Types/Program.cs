using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedOn = true;
            Console.WriteLine(isLoggedOn);

            //short example1 = 23;
            string example2 = "$3.33";
            double example3 = 15.2546;
            short example4 = -3500;
            string example5 = "Hi there, everybody!";

            Console.WriteLine(example2);
            //Console.WriteLine(example2);
            Console.WriteLine(example3);
            Console.WriteLine(example4);
            Console.WriteLine(example5);
            Console.ReadLine();
        }
    }
}
