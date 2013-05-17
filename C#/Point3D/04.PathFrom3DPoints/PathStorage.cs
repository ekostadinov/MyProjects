using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;
using System.IO;

namespace _04.PathFrom3DPoints
{
    static class PathStorage
    {
       public static void SavePath()
       {
           using (StreamWriter writer = new StreamWriter("D:\\PoitsPath.txt", true))
           {
               for (int w = 0; w < Path.StoredPoints.Count; w++)
               {
                   writer.WriteLine(Path.StoredPoints[w]);
               }
           }
       }

       public static void LoadPath()
       {
           List<string> file = new List<string>();
           using (StreamReader reader = new StreamReader("D:\\PoitsPath.txt"))
           {
               string line = null;
               while ((line = reader.ReadLine()) != null)
               {
                 file.Add(line);
                 Console.WriteLine(line);
               }              
           }          
       }

    }
}
