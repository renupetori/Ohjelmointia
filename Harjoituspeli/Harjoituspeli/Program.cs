using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mini Dungeon!");
            new CharacterCreation();

            Console.WriteLine($"Your name is {CharacterCreation._name}.");
            Console.ReadKey();

            new Character();

            new Battle();
            new Battle();
            new Battle();
            new Battle();
            new Battle();

            Console.WriteLine($"STR is: {Character._stats["STR"]}");
            Console.ReadKey();


        }
    }
}
