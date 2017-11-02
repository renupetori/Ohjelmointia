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
            Console.WriteLine(Numerohaku());
            Console.ReadLine();
        }

        public static string Numerohaku()
        {

            string tulos ="";
            int numero;
            string luvut = "";
            int isoin_rivi = 0;
            int isoin_numero = 0;
            bool numeroOk = false;
            Console.WriteLine("Syötä positiivinen luku: ");

            for (int i = 1; i <= 10; i++)
            {
                
                do
                {
                    Console.WriteLine();
                    numeroOk = int.TryParse(Console.ReadLine(), out numero);


                    if (numero > 0)
                    {
                        numeroOk = true;
                        if (numero > isoin_numero)
                        {
                            isoin_numero = numero;
                            isoin_rivi = i;
                        }

                        luvut = luvut + numero + " ";

                        Console.WriteLine($"\nRivi {i}: {numero}");

                    }
                    else
                    {
                        numeroOk = false;
                        Console.WriteLine("Virhe, syötä positiivinen luku!");
                    }

                } while (numeroOk == false);
            }

            tulos = ($"\nSyötit luvut: \n{luvut} \n \nSuurin numero oli {isoin_numero} riviltä {isoin_rivi}.");

            return tulos;
        }
    }
}
