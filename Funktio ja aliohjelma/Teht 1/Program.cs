using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);
            Console.WriteLine(funktio(luku));
            Console.ReadLine();
        }

        static string funktio(int luku)
        {
            char merkki = '*';
            string tahdet;
            tahdet = "";

            for (int i = 1; i <= luku; i++)
            {
                tahdet = tahdet + merkki;
            }
            return tahdet;
        }




    }



}
