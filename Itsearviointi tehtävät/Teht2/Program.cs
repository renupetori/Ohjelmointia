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
            Console.WriteLine("Syötä sana tai lause");
            string virke = Console.ReadLine();
            int pituus = virke.Length;

            for (int i = 0; i < pituus; i++)
            {
                Console.WriteLine($"{i}. {virke}");
            }
            Console.ReadLine();
        }
    }
}
