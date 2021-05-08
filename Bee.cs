using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Pg299_InterfaceExample
{
    class Bee : IStingPatrol
    {
        public int AlertLevel
        {
            get
            {
                return 8;
            }
        }
        public int StingerLength { get; set; }
        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int length)
        {
            return 6;
        }
    }
}
