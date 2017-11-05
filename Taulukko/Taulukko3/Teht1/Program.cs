using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] taulukko = new string[10];
            int[] rivi = new int[10];
            int numero;
            Random rnd = new Random();

            for (int i = 0; i < taulukko.Length; i++)
            {
                numero = rnd.Next(0,20);
                if (numero < 10)
                {
                    taulukko[i] = numero.ToString("00");
                }
                else
                {
                    taulukko[i] = numero.ToString("");
                }
                rivi[i] = i;
            }

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine($"Rivi [{k}] = {taulukko[k]}");
            }
            Console.ReadKey();
        }
    }
}
