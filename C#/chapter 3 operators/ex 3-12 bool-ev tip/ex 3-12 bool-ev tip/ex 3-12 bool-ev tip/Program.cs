using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_3_12_bool_ev_tip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число:");
            string line = Console.ReadLine();
            int v;
            int.TryParse(line, out v);

            Console.WriteLine("Въведете позиция:");
            string line1 = Console.ReadLine();
            int p;
            int.TryParse(line1, out p);

            int i = 1;
                        
            Console.WriteLine(p==i ? false : true);
        }
    }
}
