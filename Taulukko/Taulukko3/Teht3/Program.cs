using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] taulukko1 = new string[10];
            string[] taulukko2 = new string[10];
            string[] taulukko3 = new string[10];
            int numero;
            Random rnd = new Random();

            for (int i = 0; i < taulukko1.Length; i++)
            {
                numero = rnd.Next(0, 20);
                if (numero < 10)
                {
                    taulukko1[i] = numero.ToString("00");
                }
                else
                {
                    taulukko1[i] = numero.ToString("");
                }
            }

            for (int i = 0; i < taulukko2.Length; i++)
            {
                numero = rnd.Next(0, 20);
                if (numero < 10)
                {
                    taulukko2[i] = numero.ToString("00");
                }
                else
                {
                    taulukko2[i] = numero.ToString("");
                }
            }

            for (int i = 0; i < taulukko3.Length; i++)
            {
                int taulu1 = int.Parse(taulukko1[i]);
                int taulu2 = int.Parse(taulukko2[i]);
                if (taulu1 > taulu2)
                {
                    taulukko3[i] = taulukko1[i];
                }
                else
                {
                    taulukko3[i] = taulukko2[i];
                }
                
            }
            Console.WriteLine("           01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Taulukko1: {0}", string.Join(" ", taulukko1));
            Console.WriteLine("Taulukko2: {0}", string.Join(" ", taulukko2));
            Console.WriteLine("Taulukko3: {0}", string.Join(" ", taulukko3));

            Console.ReadKey();
        }
    }
}
