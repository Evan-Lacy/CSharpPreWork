using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 1997;
            string birth = "The year I was born is ";

            string birthMsg = birth + birthYear.ToString() + ", also known as the Year of the Ox";

            Console.WriteLine(birthMsg);
        }
    }
}
