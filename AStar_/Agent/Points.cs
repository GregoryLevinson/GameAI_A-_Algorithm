using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    public class Points
    {
        public int x  { get; set; }
        public int y { get; set; }
        public int FCost;
        public int HCost;
        public int GCost;
        public bool isBarrier { get; private set; }
        public bool isClosed { get; private set; }
        public Points(int x, int y, bool isBarrier)
        {
            this.x = x;
            this.y = y;
            this.isBarrier = isBarrier;
        }
    }
}
