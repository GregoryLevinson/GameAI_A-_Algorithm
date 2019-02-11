using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMap.GenerateMap();

            //Define End point, destintation point
            Points destinationPoint = new Points(9, 9, false);
            Points startPoint = new Points(0, 0, false);
            int boundaryX = 10;
            int boundaryY = 10;

            //-------------------- Prints Map
            bool running = true;
            while (running)
            {
                for (int y = 0; y < boundaryY; y++)
                {
                    for (int x = 0; x < boundaryX; x++)
                    {
                        Points currentPoint = GameMap.GameMapPoints[x, y];

                        currentPoint.FCost = CalculateFCost(currentPoint, startPoint, destinationPoint);
                        int fCost = CalculateFCost(currentPoint, startPoint, destinationPoint);

                        currentPoint.HCost = CalculateHCost(currentPoint, destinationPoint);
                        int hCost = CalculateHCost(currentPoint, destinationPoint);

                        currentPoint.GCost = CalculateGCost(currentPoint, startPoint);
                        int gCost = CalculateGCost(currentPoint, startPoint);

                        Console.WriteLine(string.Format("({0},{1}) fCost: {2} hCost: {3} gCost: {4} isBarrier: {5}", x, y, fCost, hCost, gCost, currentPoint.isBarrier));
                    }
                }
                running = false;
            }
            Console.ReadKey();
        }

        //-------- F Cost
        //Added DestinaitonX, and DestinaitonY to calculate H cost
        public static int CalculateFCost(Points currentPoint, Points startPoint, Points destinationPoint)
        {
            return CalculateGCost(currentPoint, startPoint) + CalculateHCost(currentPoint, destinationPoint);
        }

        //-------- H Cost
        private static int CalculateHCost(Points currentPoint, Points destinationPoint)
        { 
            //Absolute value of horizontal / vertical distance between 
            int a = Math.Abs(destinationPoint.x - currentPoint.x);
            int b = Math.Abs(destinationPoint.y - currentPoint.y);
            int c = Convert.ToInt32(Math.Sqrt((a * a) + (b * b)));
            return c;
        }

        //-------- G Cost
        private static int CalculateGCost(Points currentPoint, Points startPoint)
        {
            //Absolute value of horizontal / vertical distance between 
            int a = Math.Abs(startPoint.x - currentPoint.x);
            int b = Math.Abs(startPoint.y - currentPoint.y);
            int c = Convert.ToInt32(Math.Sqrt((a * a) + (b * b)));
            return c;

        }

    }
}