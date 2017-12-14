using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;


namespace Harjoituspeli
{
    class LevelUp
    {
        int points;

        public LevelUp()
        {
            Console.WriteLine("Level up!");
            
            
            Random rnd = new Random();
            points = rnd.Next(3);

            Console.WriteLine($"STR: {Character._stats["STR"]} +{points}");
            Character._stats["STR"] = Character._stats["STR"] + points;
            Character._stats["DEX"] = Character._stats["DEX"] + points;
            Character._stats["VIT"] = Character._stats["VIT"] + points;
            Character._stats["INT"] = Character._stats["INT"] + points;
            Character._stats["MND"] = Character._stats["MND"] + points;
            Character._stats["LCK"] = Character._stats["LCK"] + points;
            return;
        }
        

        
    }
}
