using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] number = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(50);
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{i+1}. {number[i]}");
            }

            int sum = number.Sum();
            double average = number.Average();

            Console.WriteLine($"\nSumma: {sum}");
            Console.WriteLine($"Keskiarvo: {average}");
            Console.ReadLine();
        }
    }
}
