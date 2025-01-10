using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class Player
    {
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 7;
        public int Level { get; set; } = 1;
        public int Money { get; set; } = 0;

        public Player()
        {
            
        }
    }
}
