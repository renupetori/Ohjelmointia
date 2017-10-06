using System;

namespace Harjoitus1
{
    class Valikko
    {


        public static void Main(string[] args)
        {

            int tehtnum;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Valitse tehtävä 1,2,3 tai 4 syöttämällä yksi näistä luvuista");
                Console.WriteLine("1 = Käyttäjää pyydetään kirjoittamaan ohjelmalle 1 luku. Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
                Console.WriteLine("2 = Käyttäjää pyydetään kirjoittamaan ohjelmalle 1 luku. Ohjelma tulostaa parillinen tai pariton.");
                Console.WriteLine("3 = Yhdistä 1 ja 2.");
                Console.WriteLine("4 = Käyttäjältä pyydetään 3 lukua. Ohjelma lajittelee luvut nousevaan järjestykseen.");
                Console.WriteLine("0 = poistu sovelluksesta");
                Console.WriteLine();
                tehtnum = int.Parse(Console.ReadLine());

                if (tehtnum == 1)
                    Tehtava1.Teht1();
                if (tehtnum == 2)
                    Tehtava2.Teht2();
                if (tehtnum == 3)
                    Tehtava3.Teht3();
                if (tehtnum == 4)
                    Tehtava4.Teht4();

            } while (tehtnum != 0);

        }
    }
    public class Tehtava1
    {
        public static void Teht1()
        {
            int numero;

            Console.WriteLine("Syötä numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("Numero on positiivinen");
            else
                if (numero < 0)
                Console.WriteLine("Numero on negatiivinen");
            else
                Console.WriteLine("Numero on nolla");

            Console.ReadLine();
        }
    }
    public class Tehtava2
    {
        public static void Teht2()
        {
            int numero;

            Console.WriteLine("Syötä numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Numero on parillinen");
            else
                Console.WriteLine("Numero on pariton");

            Console.ReadLine();
        }

    }
    public class Tehtava3
    {
        public static void Teht3()
        {
            int numero;
            string pari;

            Console.WriteLine("Syötä numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                pari = ("parillinen");
            else
                pari = ("pariton");

            if (numero > 0)
                Console.WriteLine($"Numero on positiivinen ja {pari}.");
            else
                if (numero < 0)
                Console.WriteLine($"Numero on negatiivinen ja {pari}.");
            else
                Console.WriteLine($"Numero on nolla ja {pari}.");

            Console.ReadLine();
        }

    }
    public class Tehtava4
    {
        public static void Teht4()
        {
            int[] luvut = new int[3];

            Console.WriteLine("Syötä ensimmäinen luku:");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku:");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä kolmas luku:");
            luvut[2] = int.Parse(Console.ReadLine());

            Array.Sort(luvut);

            Console.WriteLine();
            Console.Write("Luvut nousevassa järjestyksessä: ");
            foreach (int i in luvut)
                Console.Write(i + ", ");

            Console.ReadLine();
        }


    }
}