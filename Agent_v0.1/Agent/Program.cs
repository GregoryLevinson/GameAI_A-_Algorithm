using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            Map.generateMap();
            
            Points endPoint = new Points(9, 9, false);
            int  boundaryx = 10;
            int boundaryy = 10;
            bool running = true;
            while(running)
            {
                for (int y = (Agent.CurrentPoint.y - 1); y < (Agent.CurrentPoint.y+1); y++)
                {
                    for (int x = (Agent.CurrentPoint.x - 1); x < (Agent.CurrentPoint.x+1); x++)
                    {
                        if (x >= 0 && y >= 0)
                        {
                            CalculateFcost(x,y);
                            
                        }
                    }
                }  
                running = false;
            }
            Console.ReadKey();
        }

        //--------------------------- Calculate F Cost Function G+H cost
        //private static void CalculateFcost(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}

        private static void CalculateGcost(int x, int y)
        {
            bool checkpath = true;
            int cost;
            while(checkpath)
            {
                if (Map.map[x, y].reference != null) {
                    if (Map.map[x, y].reference.x == x)
                    {
                        //Map.map[x, y].reference.x;
                    } else if (Map.map[x, y].reference.x == y)
                    {

                    } else
                    {
                        int a = x + Map.map[x, y].reference.x;
                        int b = y + Map.map[x, y].reference.y;
                        int c = Convert.ToInt32(Math.Sqrt((a * a) + (b * b)));
                        Console.WriteLine(c);
                    }
                } else
                {
                    checkpath = false;
                }
            }

        }
    }
}
