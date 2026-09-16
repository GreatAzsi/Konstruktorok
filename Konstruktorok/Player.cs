using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorok
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Points { get; set; }
        public Player(string name, int level = 1, int points = 0)
        {
            Name = name;
            Level = level;
            Points = points;
        }
        public override string ToString()
        {
            return $"{Name} : {Level} : {Points}";
        }
    }
}
