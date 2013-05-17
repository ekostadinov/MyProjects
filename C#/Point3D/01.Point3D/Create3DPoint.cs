using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Create3DPoint
    {        
        static void Main()
        {
            My3DPoint someTestPoint = new My3DPoint(1, 5, 7);
            Console.WriteLine("The coordinates x y z of the new 3D point are: {0}", someTestPoint.ToString());
        }
    }
}
