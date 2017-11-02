using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 20;
            Console.WriteLine(NumberFromRange(lowerBound, upperBound));
            Console.ReadLine();
        }

        public static int NumberFromRange(int lowerBound, int upperBound)
        {
            
            int numero;
            bool numeroOk = false;
            do
            {
                Console.WriteLine("Syöta luku väliltä 1-20: ");
                numeroOk = int.TryParse(Console.ReadLine(), out numero);


                if (numero >= lowerBound && numero <= upperBound)
                {
                    numeroOk = true;
                    Console.WriteLine();
                }
                else
                {
                    numeroOk = false;
                    Console.WriteLine("Virheellinen luku!");
                }

            } while (numeroOk == false);

            return numero;
        }
    }
}
