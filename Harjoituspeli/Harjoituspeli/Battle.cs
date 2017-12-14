using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Harjoituspeli
{
    public class Battle
    {
        public Battle()
        {
            Console.WriteLine("Press a Key to win.");
            Console.ReadKey();

            Character._exp = Character._exp + 80;
            if (Character._exp >= 100)
            {
                new LevelUp();
            }
        }
    }
}
