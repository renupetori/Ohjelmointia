using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] lottorivi = new int[7];
            int lisanumero;
            int tuplaus;
            int numero;
            Random rnd = new Random();

            for (int i = 0; i < lottorivi.Length; i++)
            {
                numero = rnd.Next(1,41);
                while (lottorivi.Contains(numero) == true)
                {
                    numero = rnd.Next(1, 41);
                }

                lottorivi[i] = numero;

            }

            lisanumero = rnd.Next(1, 41);
            while (lottorivi.Contains(lisanumero) == true)
            {
                lisanumero = rnd.Next(1, 41);
            }

            tuplaus = rnd.Next(1, 41);
            while (tuplaus == lisanumero)
            {
                tuplaus = rnd.Next(1, 41);
            }

            Array.Sort(lottorivi);
            Console.WriteLine("Loton oikearivi on:");
            Console.Write(String.Join(", ", lottorivi.ToArray()));
            Console.WriteLine($"\n\nLisänumero: {lisanumero}\nTuplausnumero: {tuplaus}");
            Console.ReadKey();
        }
    }
}
