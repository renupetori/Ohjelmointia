using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] taulukko = new string[10, 20];
            int numero;
            int i;
            int k;
            Random rnd = new Random();

            for (i = 0; i < 10; i++)
            {

                for (k = 0; k < 20; k++)
                {
                    numero = rnd.Next(0, 100);
                    if (numero < 10)
                    {
                        taulukko[i, k] = numero.ToString("00");
                    }
                    else
                    {
                        taulukko[i, k] = numero.ToString();
                    }
                }
            }

            for (i = 0; i < 10; i++)
            {

                for (k = 0; k < 20; k++)
                {
                    Console.WriteLine($"[{i}][{k}] = {taulukko[i,k]}");
                }
            }
            Console.ReadKey();
        }
    }
}
