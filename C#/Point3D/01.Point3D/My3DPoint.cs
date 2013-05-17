using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public struct My3DPoint
    {
        private static My3DPoint point = new My3DPoint();
        private static readonly My3DPoint Point3DStart = new My3DPoint(0, 0, 0);
        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public static My3DPoint StartPoint
        {
            get { return Point3DStart; }
        }

        public My3DPoint(double x, double y, double z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static My3DPoint Point
        {
            get { return point; }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }


    }
}
