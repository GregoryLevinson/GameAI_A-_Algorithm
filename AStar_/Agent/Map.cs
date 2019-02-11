using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent
{
    public static class Map
    {

        //---------------------------
        static List<Points> barrierpoints = new List<Points>()
        {
            new Points(1,2,true),
            new Points(2,5,true),
            new Points(2,6,true),
            new Points(2,7,true),
            new Points(3,1,true),
            new Points(3,2,true),
            new Points(3,3,true),
            new Points(4,7,true),
            new Points(4,8,true),
            new Points(4,9,true),
            new Points(5,0,true),
            new Points(5,1,true),
            new Points(5,2,true),
            new Points(6,5,true),
            new Points(8,1,true),
            new Points(8,2,true),
            new Points(8,3,true),
            new Points(8,4,true),
            new Points(8,7,true),
            new Points(8,8,true),
            new Points(8,9,true),
        };

        // ---------------------------- Old Char Map
        //Define Map Space
        /*//0    1   2     3     4    5    6    7   8    9
           {"w", "w", 'w', 'w', 'w', 'g', 'w', 'w', 'W', 'w'},//0
           {'w', 'w', 'w', 'g', 'w', 'g', 'w', 'w', 'g', 'w'},//1
           {'w', 'g', 'w', 'g', 'w', 'g', 'w', 'w', 'g', 'w'},//2
           {'w', 'w', 'w', 'g', 'w', 'w', 'w', 'w', 'g', 'w'},//3
           {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'g', 'w'},//4
           {'w', 'w', 'g', 'w', 'w', 'w', 'g', 'w', 'w', 'w'},//5
           {'w', 'w', 'g', 'w', 'g', 'w', 'g', 'w', 'w', 'w'},//6
           {'w', 'w', 'g', 'w', 'g', 'w', 'w', 'w', 'g', 'w'},//7
           {'w', 'w', 'w', 'w', 'g', 'w', 'w', 'w', 'g', 'w'},//8
           {'w', 'w', 'w', 'w', 'g', 'w', 'w', 'w', 'g', 'w'} //9
         */

        public static Points[,] map = new Points[10, 10];

        public static void generateMap()
        {
            Points temppoint;
            foreach(var point in barrierpoints)
            {
                map[point.x, point.y] = point;
            }
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    
                    if(map[x,y] == null)
                    {
                        map[x, y] = new Points(x, y, false);
                    }
                }
            }
        }
    }
}
