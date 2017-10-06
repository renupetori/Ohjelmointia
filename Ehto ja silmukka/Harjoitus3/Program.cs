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
                Console.WriteLine("Valitse tehtävä 1,2,3,4 tai 5 syöttämällä yksi näistä luvuista");
                Console.WriteLine("1 = Tee ohjelma, joka tulostaa N! kertoman arvon");
                Console.WriteLine("2 = Tee ohjelma, joka laskee N ensimmäistä lukua yhteen");
                Console.WriteLine("3 = Tee ohjelma, joka laskee N:n ensimmäisen parittoman ja parillisen lukujen summan");
                Console.WriteLine("4 = Muokkaa ohjelmaa 2 niin, että se laskee myös negatiivisilla numeroilla.");
                Console.WriteLine("5 = Muokkaa ohjelmaa 3 niin, että se laskee myös negatiivisilla numeroilla.");
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
                if (tehtnum == 5)
                    Tehtava5.Teht5();

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

            if (numero >= 0)

            {
                int tulo = 1;

                for (int i = 1; i <= numero; i++)
                {
                    tulo = tulo * i;
                }
                Console.WriteLine($"Tulos: {tulo}");

            }
            else
            {
                Console.WriteLine("Virhe!");
            }

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

            if (numero >= 0)

            {
                int summa = 0;

                for (int i = 1; i <= numero; i++)
                {
                    summa = summa + i;
                }
                Console.WriteLine($"Tulos: {summa}");

            }
            else
            {
                Console.WriteLine("Virhe!");
            }

            Console.ReadLine();

        }

    }
    public class Tehtava3
    {
        public static void Teht3()
        {
            int numero;
            Console.WriteLine("Syötä numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)

            {
                int summa = 0;
                int pariton = 0;
                int pari = 0;
                for (int i = 1; i <= numero; i++)
                {
                    summa += i;
                    if (i % 2 == 0)
                        pari += i;
                    else
                        pariton += i;
                }
                
                Console.WriteLine($"Parittomien summa: {pariton}");
                Console.WriteLine($"Parillisien summa: {pari}");
                Console.WriteLine($"Yhteensä {summa}");

            }
            else
            {
                Console.WriteLine("Virhe!");
            }

            Console.ReadLine();
            
        }

    }
    public class Tehtava4
    {
        public static void Teht4()
        {
            int numero;
            Console.WriteLine("Syötä numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)

            {
                int summa = 0;

                for (int i = 1; i <= numero; i++)
                {
                    summa = summa + i;
                }
                Console.WriteLine($"Tulos: {summa}");

            }
            if (numero < 0)

            {
                int summa = 0;

                for (int i = -1; i >= numero; i--)
                {
                    summa = summa + i;
                }
                Console.WriteLine($"Tulos: {summa}");
            }
            else
            {
                Console.WriteLine("Virhe!");
            }

            Console.ReadLine();
        }


    }
    public class Tehtava5
    {
        public static void Teht5()
        {
            int numero;
            Console.WriteLine("Syötä numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)

            {
                int summa = 0;
                int pariton = 0;
                int pari = 0;
                for (int i = 1; i <= numero; i++)
                {
                    summa += i;
                    if (i % 2 == 0)
                        pari += i;
                    else
                        pariton += i;
                }

                Console.WriteLine($"Parittomien summa: {pariton}");
                Console.WriteLine($"Parillisien summa: {pari}");
                Console.WriteLine($"Yhteensä {summa}");

            }
            if (numero < 0)

            {
                int summa = 0;
                int pariton = 0;
                int pari = 0;
                for (int i = -1; i >= numero; i--)
                {
                    summa += i;
                    if (i % 2 == 0)
                        pari += i;
                    else
                        pariton += i;
                }

                Console.WriteLine($"Parittomien summa: {pariton}");
                Console.WriteLine($"Parillisien summa: {pari}");
                Console.WriteLine($"Yhteensä {summa}");

            }
            else
            {
                Console.WriteLine("Virhe!");
            }

            Console.ReadLine();


        }

    }
}
