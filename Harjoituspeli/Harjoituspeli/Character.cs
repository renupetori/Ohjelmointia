using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Harjoituspeli
{
    public class Character
    {
        public static string _name = CharacterCreation._name;
        public static Dictionary<string, int> _stats { get; set; }
        public static int _exp;

        public Character()
        {
            string _name = CharacterCreation._name;
            _exp = 0;

            _stats = new Dictionary<string, int>()
            {
                {"LVL", 1 },
                {"STR", 5 },
                {"DEX", 5 },
                {"VIT", 5 },
                {"INT", 5 },
                {"MND", 5 },
                {"LCK", 5 }
            };

            return;
        }

       
    }
}
