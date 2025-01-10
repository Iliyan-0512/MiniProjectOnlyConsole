using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class Enemy
    {
        public int Health { get;  set; } = 70;
        public virtual int  Attack { get;  set; } = 5;
        public int Level { get;  set; } = 1;
       
        public Enemy()
        {

        }
    }
}
