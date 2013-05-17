using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public static class CalculatePointsDistance
    {        
        public static void ReadPointsCoord()
        {
            My3DPoint pointOne = new My3DPoint();
            My3DPoint pointTwo = new My3DPoint();
       
            Console.WriteLine("To calculate distance between two point in the 3D space,");
            Console.WriteLine("- enter first point cordinates x,y,z using space between them: ");
            string fiPointCoord = Console.ReadLine();
            string [] fiPointCoordArr = fiPointCoord.Split(' ');

            pointOne.X = double.Parse(fiPointCoordArr[0]);
            pointOne.Y = double.Parse(fiPointCoordArr[1]);
            pointOne.Z = double.Parse(fiPointCoordArr[2]);

            Console.WriteLine("- enter second point cordinates x,y,z using space between them: ");
            string secPointCoord = Console.ReadLine();
            string[] secPointCoordArr = secPointCoord.Split(' ');
            
            pointTwo.X = double.Parse(secPointCoordArr[0]);
            pointTwo.Y = double.Parse(secPointCoordArr[1]);
            pointTwo.Z = double.Parse(secPointCoordArr[2]);

            double finalDistance = 0;

            CalcDistance(pointOne, pointTwo, finalDistance);
                       
        }

        private static double CalcDistance(My3DPoint pointOne, My3DPoint pointTwo, double finalDistance)
        {           
            finalDistance = Math.Sqrt(((pointTwo.X - pointOne.X) * (pointTwo.X - pointOne.X)) + ((pointTwo.Y - pointOne.Y) * (pointTwo.Y - pointOne.Y)) + ((pointTwo.Z - pointOne.Z) * (pointTwo.Z - pointOne.Z)));

            Console.WriteLine("The distance between your two points is: {0}", finalDistance);
            
            return finalDistance;
        }

    }
}
