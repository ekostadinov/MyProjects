using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_2_reverse
{
    class Reverse
    {
        static void Main()
        {
            string intro = "introduction";
            string reversed = ReverseText(intro);
            Console.WriteLine(reversed);
        }
    
        public static string ReverseText(string intro)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = intro.Length - 1; i >= 0; i--)            
                sb.Append(intro[i]);
                return sb.ToString();
            
        }
    }
}
