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
                Console.WriteLine("Valitse tehtävä 1,2,3,4,5 tai 6 syöttämällä yksi näistä luvuista");
                Console.WriteLine("1 = Tee ohjelma, joka tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret.");
                Console.WriteLine("2 = Tee ohjelma, joka tulostaa kertotaulun luvuille 1-9.");
                Console.WriteLine("3 = Tee ohjelma, joka tulostaa 20 satunnaista kokonaislukua väliltä [0-50].");
                Console.WriteLine("4 = Kruuna tai Klaava");
                Console.WriteLine("5 = Tee ohjelma, joka tulostaa vakioveikkauksen rivin");
                Console.WriteLine("6 = Tee ohjelma, joka simuloi nopanheittoa 1000 kertaa");
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
                if (tehtnum == 6)
                    Tehtava6.Teht6();

            } while (tehtnum != 0);

        }
    }
    public class Tehtava1
    {
        public static void Teht1()
        {


            Console.WriteLine("Luku   Neliöjuuri");
            for (int i = 1; i <= 10; i++)
            {
                double juuri;
                juuri = Math.Sqrt(i);
                Console.WriteLine($"{i}          {juuri}");
                
            }

            Console.ReadLine();

        }
    }
    public class Tehtava2
    {
        public static void Teht2()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    int tulos = k * i;
                    Console.WriteLine();
                    Console.WriteLine($"{k} * {i} = {tulos}");
                    
                }
                Console.WriteLine("--------------------------");
            }
            Console.ReadLine();

        }

    }
    public class Tehtava3
    {
        public static void Teht3()
        {
            int[] numero = new int[5];
            Random rnd1 = new Random();

            for (int i = 1; i <= 4; i++)
            {
                
                for (int k = 0; k < numero.Length; k++)
                {

                    numero[k] = rnd1.Next(50);
 
                }
                Console.Write($"Rivi {i}: ");
                Console.Write(string.Join(", ", numero));
                Console.WriteLine();
            }
            Console.ReadLine();


        }

    }
    public class Tehtava4
    {
        public static void Teht4()
        {
            Console.WriteLine("Kuinka monta kertaa haluat heittää kolikon?");
            Console.WriteLine();
            int i = int.Parse(Console.ReadLine());
            int kruuna = 0;
            int klaava = 0;
            Random kolikko = new Random();

            for (int k = 0; k < i; k++)
            {
                if (kolikko.Next(2) == 1)
                    kruuna = kruuna + 1;
                else
                    klaava = klaava + 1;
            }

            Console.WriteLine($"Rahaa heitettiin {i} kertaa.");
            Console.WriteLine($"Klaavoja tuli {klaava} ja kruunuja {kruuna}.");
            Console.ReadLine();

        }


    }
    public class Tehtava5
    {
        public static void Teht5()
        {

            string tulos;
            Random matsi = new Random();

            for (int i = 1; i < 13; i++)
            {

                if (matsi.NextDouble() < 0.4)
                    tulos = "1";
                else if (matsi.NextDouble() > 0.6)
                    tulos = "2";
                else
                    tulos = "X";
                Console.WriteLine($"Rivi {i}: {tulos}");
            }
            
            Console.ReadLine();

        }

    }

    public class Tehtava6
    {
        public static void Teht6()
        {

            int heitto;
            int kutonen = 0;
            Random noppa = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                heitto = noppa.Next(1,7);

                Console.WriteLine($"{i}. {heitto}");

                if (heitto == 6)
                    kutonen = kutonen + 1;
            }

            Console.WriteLine();
            Console.WriteLine($"Kuutonen arvottiin {kutonen} kertaa.");
            Console.ReadLine();

        }

    }
}
