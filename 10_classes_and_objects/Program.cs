using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the objects
            Donut sierraDonut = new Donut();
            Donut alyssaDonut = new Donut();
            Donut evanDonut = new Donut();

            //setting property values - SD Prework 3.11 Properties
            sierraDonut.filling = "Cherry";
            sierraDonut.Price = 3;
            sierraDonut.Type = "normal";
            sierraDonut.isSpecial = true;

            alyssaDonut.filling = "custard";
            alyssaDonut.Price = 4;
            alyssaDonut.Type = "large";
            alyssaDonut.isSpecial = false;

            evanDonut.filling = "none";
            evanDonut.Price = 2;
            evanDonut.Type = "normal";
            evanDonut.isSpecial = true;

            Console.WriteLine(evanDonut.filling);

        }
    }
}
