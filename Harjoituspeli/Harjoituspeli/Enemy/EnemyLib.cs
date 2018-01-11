using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli
{
    public class EnemyLib
    {
        public static Dictionary<string, int> _goblin { get; set; }

        public EnemyLib()
        {
            string _goblin_name = "Goblin";
            _goblin = new Dictionary<string, int>()
            {
                    {"LVL", 1 },
                    {"STR", 2 },
                    {"DEX", 3 },
                    {"VIT", 2 },
                    {"INT", 1 },
                    {"MND", 1 },
                    {"LCK", 1 },
                    {"EXP", 80}
            };
        }
}
}
