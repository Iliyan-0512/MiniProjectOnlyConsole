using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class Player
    {
        public int Health { get; private set; } = 100;
        public int Attack { get; private set; } = 5;
        public int Level { get; private set; } = 1;
        public int Money { get; private set; } = 0;

        public Player()
        {
            
        }
    }
}
