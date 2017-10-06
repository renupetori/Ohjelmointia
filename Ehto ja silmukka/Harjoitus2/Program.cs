using System;

namespace Harjoitus2
{
    class Tehtava
    {

        public static void Main(string[] args)
        {
            ///muuttujat
            double lippu = 16;
            int ika;
            string opiskelija;
            string varusmies;
            string mtk;
            ///kysytään ja määritetään ikä
            Console.WriteLine("Syötä ikäsi:");
            ika = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Oletko opiskelija? K/E");
                opiskelija = Console.ReadLine();
                if (opiskelija != "K" && opiskelija != "E")
                    Console.WriteLine("Väärä vaihtoehto! K = Kyllä, E = En");

            } while (opiskelija != "K" && opiskelija != "E");

            do
            {
                Console.WriteLine("Oletko varusmies? K/E");
                varusmies = Console.ReadLine();
                if (varusmies != "K" && varusmies != "E")
                    Console.WriteLine("Väärä vaihtoehto! K = Kyllä, E = En");

            } while (varusmies != "K" && varusmies != "E");

            do
            {
                Console.WriteLine("Oletko MTK:n jäsen? K/E");
                mtk = Console.ReadLine();
                if (mtk != "K" && mtk != "E")
                    Console.WriteLine("Väärä vaihtoehto! K = Kyllä, E = En");

            } while (mtk != "K" && mtk != "E");




            if (ika < 7)
                lippu = lippu * 0;

            else
                if (mtk == "K" && opiskelija == "K")
                lippu = lippu * 0.85 * 0.55;
            else
                if (ika >= 65)
                lippu = lippu * 0.50;
            else
                if (ika >= 7 && ika <= 15)
                lippu = lippu * 0.50;
            else
                if (varusmies == "K")
                lippu = lippu * 0.50;
            else
                if (opiskelija == "K")
                lippu = lippu * 0.55;
            else
                if (mtk == "K")
                lippu = lippu * 0.85;


            Console.WriteLine($"Lippusi alennettu hinta on {lippu}€!");
            Console.ReadLine();

        }
    }
}