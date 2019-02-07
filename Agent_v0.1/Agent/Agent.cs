using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent
{
    public static class Agent
    {
        public static int boundary = 9;
        public static Points CurrentPoint = new Points(0, 0, false);
        public static Points[,] discoveredMap = new Points[9, 9];


        public static void MoveX()
        {
            CurrentPoint.x++;
        }

        public static void MoveY()
        {
            CurrentPoint.y++;
        }
        /// <summary>
        /// Checks if grey
        /// </summary>
        /// <returns>if the spot is grey or not</returns>
        public static bool CheckLocation()
        {
            bool grey = false;
            if(CurrentPoint.x > boundary || CurrentPoint.y > boundary) {
                grey = true;
            } else { 
                if (Map.map[CurrentPoint.x, CurrentPoint.y].isBlock == true)
                {
                    grey = true;
                }
            }
            
            return grey;
        }
    }
}
