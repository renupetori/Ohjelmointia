using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli
{
    public class CharacterCreation
    {


        public static string _name;

        public CharacterCreation()
        {
            bool nameOk = false;
            do
            {
                Console.WriteLine("\nPlease enter your character's name:");
                _name = Console.ReadLine();
                if (_name.Length < 3)
                {
                    nameOk = false;
                    Console.WriteLine("Your name has to be at least 3 characters long.\n");
                }
                else
                {
                    nameOk = true;
                    Console.WriteLine($"\nWelcome {_name}!");
                    Console.ReadKey();
                }

            } while (nameOk == false);

            return;
        }

        

    }
}
