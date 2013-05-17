using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _04.PathFrom3DPoints
{
    class Path
    {
        private static int pointsNumber;
        private static List<My3DPoint> storedPoints;

        public static List<My3DPoint> StoredPoints
        {
            get { return storedPoints; }
            set { storedPoints = value; }
        }

        public static int PointsNumber
        {
            get { return pointsNumber; }
            set { pointsNumber = value; }
        }

        public static int HoldPointSequence() 
        {
            storedPoints = new List<My3DPoint>();
            My3DPoint currPoint = new My3DPoint();
            Console.WriteLine("Now enter each 3D point coordinates (x y z) using space between them: ");
            string pointCoord = string.Empty;

            for (int p = 0; p < pointsNumber; p++)
            {
                Console.WriteLine("point {0} coordinates: ", p);
                pointCoord = Console.ReadLine();
                string[] pointCoordArr = pointCoord.Split(' ');
                currPoint.X= int.Parse(pointCoordArr[0]);
                currPoint.Y = int.Parse(pointCoordArr[1]);
                currPoint.Z = int.Parse(pointCoordArr[2]);
                storedPoints.Add(currPoint);    
            }
            return pointsNumber;
        }
        
    }
}
