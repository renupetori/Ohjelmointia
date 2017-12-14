using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä_30._11
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] prepositiot = { "of", "the" };

            Console.WriteLine("Kirjoita lause missä on isoja ja pieniä kirjaimia:");
            Console.WriteLine();
            string lause = Console.ReadLine();
            Toiminnot p = new Toiminnot (lause);
            Console.WriteLine(p.Tulostus());

            Console.ReadKey();




        }
    }
}
