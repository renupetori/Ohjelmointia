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
            Console.WriteLine("Syötä lukuja, ohjelma laskee ne yhteen kunnes syötät luvun '-1'");
            int luku = 0;
            int luvut = 0;
            do
            {
                Console.WriteLine();
                luku = int.Parse(Console.ReadLine());
                if (luku != -1)
                    luvut = luvut + luku;
            }
            while (luku != -1);
            Console.WriteLine($"Lukujen summa on {luvut}");
            Console.ReadLine();
        }
    }
}
