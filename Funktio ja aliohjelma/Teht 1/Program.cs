using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku: ");
            int luku = int.Parse(Console.ReadLine());
            if (luku >0)
                Console.WriteLine(tahtifunktio(luku));
            else
                Console.WriteLine($"Numero {luku} ei ole kelvollinen.");
            Console.ReadLine();
        }

        public static string tahtifunktio(int luku)
        {
            char tahti = '*';
            string tahdet = "";

            for (int i = 1; i <= luku; i++)
            {
                tahdet = tahdet + tahti;
            }
            return tahdet;
        }
    }
}
