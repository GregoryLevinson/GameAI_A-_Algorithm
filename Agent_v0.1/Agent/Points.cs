using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent
{
    public class Points
    {
        public int x  { get; set; }
        public int y { get; set; }
        public int Fcost;
        public Points reference;
        public bool isBlock { get; private set; }
        public bool closed { get; set; }
        public Points(int x, int y, bool isBlock)
        {
            this.x = x;
            this.y = y;
            this.closed = true;
            this.isBlock = isBlock;
        }
    }
}
