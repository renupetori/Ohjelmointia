using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Syötä ensimmäinen luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Minimi(luku1,luku2);
            Console.ReadLine();
        }

        public static void Minimi(int luku1, int luku2)
        {
            if (luku1 < luku2)
                Console.WriteLine($"Luku {luku1} on pienempi kuin {luku2}.");
            else if (luku2 < luku1)
                Console.WriteLine($"Luku {luku2} on pienempi kuin {luku1}.");
            else
                Console.WriteLine($"Luvut {luku1} ja {luku2} ovat yhtä suuria");
                
        }
        
    }
}
