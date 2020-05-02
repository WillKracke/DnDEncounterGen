using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDEncounterGen
{
    class creature
    {
        // Charecteristics of Creature
        public string name;
        public string type;
        public int cost;

        /// <summary>
        /// Constructs a new creature object
        /// </summary>
        /// <param name="n">Name of creature</param>
        /// <param name="t">Type of creature</param>
        /// <param name="c">Cost, in XP</param>
        public creature(string n, string t, int c)
        {
            name = n;
            type = t;
            cost = c;
        }
    }
}
