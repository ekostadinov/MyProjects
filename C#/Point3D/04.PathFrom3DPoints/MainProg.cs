using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _04.PathFrom3DPoints
{
    public class MainProg
    {          
        static void Main()
        {
            Console.WriteLine("Enter how many points you want to create: ");
            Path.PointsNumber = int.Parse(Console.ReadLine());
        
            Path.HoldPointSequence();

            PathStorage.SavePath();

            Console.WriteLine("The coordinates of your 3D points are: ");
            PathStorage.LoadPath();
        }
    }
}
